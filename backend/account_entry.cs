/// <summary>
/// Represents a stored account with an AES-256 encrypted password and its
/// corresponding initialization vector. Used as the data model for account
/// serialization and deserialization to/from JSON storage.
/// </summary>
/// 
public enum AccountType
{
    Personal,
    School,
    Work
}
public class AccountEntry
{
    /// <summary>
    /// The account username or email address associated with the stored credentials.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The AES-256 encrypted password encoded as a Base64 string.
    /// Decrypted at runtime using the matching IV and encryption key.
    /// </summary>
    public string EncryptedPassword { get; set; }

    /// <summary>
    /// The 16-byte AES initialization vector used to encrypt the password,
    /// encoded as a Base64 string. Required alongside the key to decrypt.
    /// </summary>
    public string IV { get; set; }

    /// <summary>
    /// Creates an empty account entry with default property values.
    /// Useful for deserialization scenarios where properties are populated
    /// after construction.
    /// </summary>
    /// 
    public AccountType Type { get; set; }
    // specifies account type for work, personal or school use, not used in encryption/decryption
    public AccountEntry() { }

    /// <summary>
    /// Creates a new account entry with pre-encrypted credentials.
    /// Typically constructed after encrypting a plaintext password
    /// through <see cref="AesCrypto.Encrypt"/>.
    ///
    /// Args:
    ///     username: The account username or email address.
    ///     encryptedPassword: The Base64-encoded AES-256 encrypted password.
    ///     iv: The Base64-encoded AES initialization vector used during encryption.
    /// </summary>
    public AccountEntry(string username, string encryptedPassword, string iv, AccountType type)
    {
        Username = username;
        EncryptedPassword = encryptedPassword;
        IV = iv;
        Type = type;

    }
}
