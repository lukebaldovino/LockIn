using System.Text.Json;
public static class AccountStorage
{
    private const string FilePath = "accounts.json";

    public static void Save(Dictionary<string, AccountEntry> accounts)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };

        using FileStream stream = File.Open(FilePath, FileMode.Create, FileAccess.Write, FileShare.None);
        JsonSerializer.Serialize(stream, accounts, options);
    }

    public static Dictionary<string, AccountEntry> Load()
    {
        if (!File.Exists(FilePath))
            return new Dictionary<string, AccountEntry>();

        using FileStream stream = File.OpenRead(FilePath);
        return JsonSerializer.Deserialize<Dictionary<string, AccountEntry>>(stream)
               ?? new Dictionary<string, AccountEntry>();
    }
}