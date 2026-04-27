using System.Security.Cryptography;

/// <summary>
/// Provides AES-256 encryption and decryption using CBC mode with PKCS7 padding.
/// Uses a statically stored 256-bit key that must be set before any encryption
/// or decryption operations. Each encryption call generates a cryptographically
/// random 16-byte initialization vector.
///
/// Notes:
///     - The key is stored in memory as a copy; the original array is not retained.
///     - All encrypted output and IVs are returned as Base64 strings for JSON storage.
///     - Encryption without a set key throws InvalidOperationException.
/// </summary>
public static class AesCrypto
{
    private static byte[]? _key;

    /// <summary>
    /// Sets the AES-256 encryption key used for all subsequent encryption and
    /// decryption operations. The key is copied internally so the caller retains
    /// ownership of the original array.
    ///
    /// Args:
    ///     key: A 32-byte (256-bit) array representing the AES encryption key.
    ///
    /// Raises:
    ///     ArgumentException: If the provided key is not exactly 32 bytes in length.
    /// </summary>
    public static void SetKey(byte[] key)
    {
        if (key.Length != 32)
            throw new ArgumentException("Key must be 32 bytes for AES-256.");

        _key = new byte[32];
        Buffer.BlockCopy(key, 0, _key, 0, 32);
    }

    /// <summary>
    /// Generates a cryptographically random 256-bit key suitable for AES-256
    /// encryption. The key is returned as a Base64-encoded string for portability
    /// and can be stored externally for later use with SetKey.
    ///
    /// Returns:
    ///     string: A Base64-encoded 32-byte cryptographically random key.
    /// </summary>
    public static string GenerateKey()
    {
        var key = new byte[32];
        RandomNumberGenerator.Fill(key);
        return Convert.ToBase64String(key);
    }

    /// <summary>
    /// Encrypts a plaintext string using AES-256-CBC with a randomly generated
    /// initialization vector. The IV is generated anew for each encryption call
    /// to ensure semantic security.
    ///
    /// Args:
    ///     plainText: The plaintext string to encrypt (UTF-8 encoded).
    ///
    /// Returns:
    ///     (string encryptedData, string iv): A tuple containing:
    ///         - encryptedData: The Base64-encoded ciphertext.
    ///         - iv: The Base64-encoded 16-byte initialization vector used.
    ///
    /// Raises:
    ///     InvalidOperationException: If the encryption key has not been set via SetKey.
    /// </summary>
    public static (string encryptedData, string iv) Encrypt(string plainText)
    {
        if (_key == null)
            throw new InvalidOperationException("Encryption key has not been set. Call SetKey first.");

        using var aes = Aes.Create();
        aes.KeySize = 256;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        var iv = new byte[16];
        RandomNumberGenerator.Fill(iv);

        using var encryptor = aes.CreateEncryptor(_key, iv);
        var plainBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        var cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

        return (
            Convert.ToBase64String(cipherBytes),
            Convert.ToBase64String(iv)
        );
    }

    /// <summary>
    /// Decrypts a Base64-encoded ciphertext using the stored AES-256 key and
    /// the provided initialization vector. Returns the original UTF-8 plaintext.
    ///
    /// Args:
    ///     encryptedData: The Base64-encoded ciphertext produced by Encrypt.
    ///     iv: The Base64-encoded initialization vector that was used during encryption.
    ///
    /// Returns:
    ///     string: The decrypted plaintext string (UTF-8).
    ///
    /// Raises:
    ///     InvalidOperationException: If the decryption key has not been set via SetKey.
    ///     CryptographicException: If the ciphertext or IV is invalid or tampered with.
    /// </summary>
    public static string Decrypt(string encryptedData, string iv)
    {
        if (_key == null)
            throw new InvalidOperationException("Decryption key has not been set. Call SetKey first.");

        using var aes = Aes.Create();
        aes.KeySize = 256;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        var cipherBytes = Convert.FromBase64String(encryptedData);
        var ivBytes = Convert.FromBase64String(iv);

        using var decryptor = aes.CreateDecryptor(_key, ivBytes);
        var plainBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

        return System.Text.Encoding.UTF8.GetString(plainBytes);
    }
}
