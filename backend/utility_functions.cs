/// <summary>
/// High-level utility functions that automate the complete account management
/// workflow: input, encrypt, save to JSON, and the reverse of load, decrypt, output.
/// All methods log their operations using the Logger class.
///
/// Notes:
///     - Call Initialize once at application startup before using any other method.
///     - All methods are synchronous and read/modify the full accounts.json on each call.
///     - serviceKey is the dictionary key used to identify accounts (e.g., "github").
/// </summary>
public static class UtilityFunctions
{
    /// <summary>
    /// Initializes the encryption subsystem with the provided AES-256 key.
    /// Must be called once before any account operations that involve encryption.
    ///
    /// Args:
    ///     key: A 32-byte (256-bit) AES encryption key. Generate one via
    ///          AesCrypto.GenerateKey() or load a previously saved key.
    /// </summary>
    public static void Initialize(byte[] key)
    {
        AesCrypto.SetKey(key);
    }

    /// <summary>
    /// Creates a new account by encrypting the provided password and saving
    /// it to accounts.json alongside the username and service key. Automates
    /// the Input → Encrypt → Save to JSON flow.
    ///
    /// Args:
    ///     serviceKey: The identifier for the service (e.g., "github", "gmail").
    ///     username: The account username or email address.
    ///     password: The plaintext password to encrypt and store.
    ///
    /// Returns:
    ///     (string serviceKey, string username): The service key and username
    ///     of the created account, confirming the operation.
    ///
    /// Raises:
    ///     InvalidOperationException: If Initialize has not been called.
    /// </summary>
    public static (string serviceKey, string username) CreateAccount(string serviceKey, string username, string password, AccountType type)
    {
        var accounts = AccountStorage.Load();
        var (cipher, iv) = AesCrypto.Encrypt(password);
        accounts[serviceKey] = new AccountEntry(username, cipher, iv, type);
        AccountStorage.Save(accounts);
        Logger.Info($"Account created: serviceKey={serviceKey}, username={username}");
        return (serviceKey, username);
    }

    /// <summary>
    /// Loads an account from accounts.json and decrypts its stored password.
    /// Automates the Load → Decrypt → Output flow for a single account.
    ///
    /// Args:
    ///     serviceKey: The service identifier to look up (e.g., "github").
    ///
    /// Returns:
    ///     (string serviceKey, string username, string password): The service
    ///     key, username, and decrypted plaintext password for the account.
    ///
    /// Raises:
    ///     KeyNotFoundException: If no account exists for the given serviceKey.
    ///     InvalidOperationException: If Initialize has not been called.
    /// </summary>
    public static (string serviceKey, string username, string password) LoadAndDecrypt(string serviceKey)
    {
        var accounts = AccountStorage.Load();
        if (!accounts.TryGetValue(serviceKey, out var entry))
            throw new KeyNotFoundException($"Account not found for serviceKey: {serviceKey}");

        var password = AesCrypto.Decrypt(entry.EncryptedPassword, entry.IV);
        return (serviceKey, entry.Username, password);
    }

    /// <summary>
    /// Loads all accounts from accounts.json and decrypts every stored
    /// password. Returns a dictionary with plaintext credentials.
    ///
    /// Returns:
    ///     Dictionary&lt;string, (string username, string password)&gt;: All accounts
    ///     keyed by service name, each containing the username and decrypted
    ///     plaintext password.
    ///
    /// Raises:
    ///     InvalidOperationException: If Initialize has not been called.
    /// </summary>
    public static Dictionary<string, (string username, string password)> LoadAndDecryptAll()
    {
        var accounts = AccountStorage.Load();
        var result = new Dictionary<string, (string username, string password)>();

        foreach (var kvp in accounts)
        {
            var password = AesCrypto.Decrypt(kvp.Value.EncryptedPassword, kvp.Value.IV);
            result[kvp.Key] = (kvp.Value.Username, password);
        }

        return result;
    }

    /// <summary>
    /// Deletes an account from accounts.json by its service key. Returns
    /// whether an entry was actually found and removed.
    ///
    /// Args:
    ///     serviceKey: The service identifier of the account to delete.
    ///
    /// Returns:
    ///     bool: True if the account was found and deleted; false if it
    ///     did not exist.
    /// </summary>
    public static bool DeleteAccount(string serviceKey)
    {
        var accounts = AccountStorage.Load();
        if (!accounts.Remove(serviceKey))
            return false;

        AccountStorage.Save(accounts);
        Logger.Info($"Account deleted: serviceKey={serviceKey}");
        return true;
    }

    /// <summary>
    /// Checks whether an account exists for the given service key.
    ///
    /// Args:
    ///     serviceKey: The service identifier to check.
    ///
    /// Returns:
    ///     bool: True if an account exists for the service key; false otherwise.
    /// </summary>
    public static bool AccountExists(string serviceKey)
    {
        var accounts = AccountStorage.Load();
        return accounts.ContainsKey(serviceKey);
    }

    /// <summary>
    /// Updates an existing account's password by re-encrypting the new
    /// plaintext and saving it to accounts.json. The username is preserved.
    ///
    /// Args:
    ///     serviceKey: The service identifier of the account to update.
    ///     newPassword: The new plaintext password to encrypt and store.
    ///
    /// Returns:
    ///     (string serviceKey, string username): The service key and username
    ///     of the updated account, confirming the operation.
    ///
    /// Raises:
    ///     KeyNotFoundException: If no account exists for the given serviceKey.
    ///     InvalidOperationException: If Initialize has not been called.
    /// </summary>
    public static (string serviceKey, string username) UpdatePassword(string serviceKey, string newPassword)
    {
        var accounts = AccountStorage.Load();
        if (!accounts.TryGetValue(serviceKey, out var entry))
            throw new KeyNotFoundException($"Account not found for serviceKey: {serviceKey}");

        var (cipher, iv) = AesCrypto.Encrypt(newPassword);
        accounts[serviceKey] = new AccountEntry(entry.Username, cipher, iv, entry.Type);
        AccountStorage.Save(accounts);
        Logger.Info($"Password updated for: serviceKey={serviceKey}");
        return (serviceKey, entry.Username);
    }

    /// <summary>
    /// Returns the raw encrypted accounts dictionary directly from storage
    /// without decrypting any passwords. Useful for inspection or bulk operations.
    ///
    /// Returns:
    ///     Dictionary&lt;string, AccountEntry&gt;: All stored account entries with
    ///     their encrypted passwords and IVs intact.
    /// </summary>
    public static Dictionary<string, AccountEntry> LoadAllRaw()
    {
        return AccountStorage.Load();
    }
}
