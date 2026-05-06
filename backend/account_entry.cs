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
    public string Username { get; set; } = "";

    public string EncryptedPassword { get; set; } = "";

    public string IV { get; set; } = "";

    public AccountType Type { get; set; }

    public AccountEntry() { }

    public AccountEntry(string username, string encryptedPassword, string iv, AccountType type)
    {
        Username = username;
        EncryptedPassword = encryptedPassword;
        IV = iv;
        Type = type;
    }
}

