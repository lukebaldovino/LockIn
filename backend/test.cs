using System;
using System.Collections.Generic;

// Example: create account entries, save them to JSON, then load them back.
var accounts = new Dictionary<string, AccountEntry>
{
    ["alice"] = new AccountEntry("alice", "encrypted123", "ivvalue"),
    ["bob"] = new AccountEntry("bob", "encrypted456", "ivvalue2")
};

AccountStorage.Save(accounts);
Console.WriteLine("Saved accounts to accounts.json");

var loadedAccounts = AccountStorage.Load();
Console.WriteLine($"Loaded {loadedAccounts.Count} accounts:");

foreach (var kvp in loadedAccounts)
{
    var entry = kvp.Value;
    Console.WriteLine($"Key: {kvp.Key}, Username: {entry.Username}, EncryptedPassword: {entry.EncryptedPassword}, IV: {entry.IV}");
}

Logger.Info("Test completed");