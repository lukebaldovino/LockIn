public static class Tests
{
    public static void Run()
    {
        var accounts = new Dictionary<string, AccountEntry>
        {
            ["alice"] = new AccountEntry("alice", "encrypted123", "ivvalue", AccountType.School),
            ["bob"] = new AccountEntry("bob", "encrypted456", "ivvalue2", AccountType.Work)
        };

        AccountStorage.Save(accounts);
        Console.WriteLine("Saved accounts to accounts.json");

        var loadedAccounts = AccountStorage.Load();
        Console.WriteLine($"Loaded {loadedAccounts.Count} accounts:");

        foreach (var kvp in loadedAccounts)
        {
            var entry = kvp.Value;
            Console.WriteLine($"Key: {kvp.Key}, Username: {entry.Username}");
        }

        Logger.Info("Test completed");
    }
}