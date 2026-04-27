using System.Text.Json;

/// <summary>
/// Provides methods to persist and retrieve a dictionary of account entries
/// as a JSON file on disk. All account data is stored with indented formatting
/// for human readability.
/// </summary>
public static class AccountStorage
{
    private const string FilePath = "accounts.json";

    /// <summary>
    /// Serializes the given accounts dictionary to accounts.json using indented
    /// JSON formatting. Overwrites any existing file content completely.
    ///
    /// Args:
    ///     accounts: The dictionary of account entries keyed by service name
    ///               (e.g., "github", "gmail") to persist to disk.
    /// </summary>
    public static void Save(Dictionary<string, AccountEntry> accounts)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };

        using FileStream stream = File.Open(FilePath, FileMode.Create, FileAccess.Write, FileShare.None);
        JsonSerializer.Serialize(stream, accounts, options);
    }

    /// <summary>
    /// Loads and deserializes accounts.json from disk into a dictionary of
    /// account entries. Returns an empty dictionary when no file exists yet,
    /// allowing first-run scenarios without errors.
    ///
    /// Returns:
    ///     Dictionary&lt;string, AccountEntry&gt;: Account entries keyed by service
    ///     name. Returns an empty dictionary if accounts.json does not exist.
    /// </summary>
    public static Dictionary<string, AccountEntry> Load()
    {
        if (!File.Exists(FilePath))
            return new Dictionary<string, AccountEntry>();

        using FileStream stream = File.OpenRead(FilePath);
        return JsonSerializer.Deserialize<Dictionary<string, AccountEntry>>(stream)
               ?? new Dictionary<string, AccountEntry>();
    }
}
