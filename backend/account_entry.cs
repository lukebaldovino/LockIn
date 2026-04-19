public class AccountEntry
{
    public string Username { get; set; }
    public string EncryptedPassword { get; set; }
    public string IV { get; set; }
    public AccountEntry() { }

    public AccountEntry(string username, string encryptedPassword, string iv)
    {
        Username = username;
        EncryptedPassword = encryptedPassword;
        IV = iv;
    }
}