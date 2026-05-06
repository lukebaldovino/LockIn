using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

public static class MasterAccount
{
    private const string FilePath = "master.json";

    public static bool Exists()
    {
        return File.Exists(FilePath);
    }

    public static void Save(string username, string password)
    {
        byte[] key = DeriveKey(password);
        var data = new { Username = username, KeyBase64 = Convert.ToBase64String(key) };
        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    public static (string username, byte[] key)? Load()
    {
        if (!File.Exists(FilePath))
            return null;
        var doc = JsonDocument.Parse(File.ReadAllText(FilePath));
        var root = doc.RootElement;
        string username = root.GetProperty("Username").GetString() ?? "";
        byte[] key = Convert.FromBase64String(root.GetProperty("KeyBase64").GetString()!);
        return (username, key);
    }

    public static bool Verify(string password)
    {
        if (!File.Exists(FilePath)) return false;
        var doc = JsonDocument.Parse(File.ReadAllText(FilePath));
        byte[] expectedKey = DeriveKey(password);
        string expectedBase64 = Convert.ToBase64String(expectedKey);
        string storedBase64 = doc.RootElement.GetProperty("KeyBase64").GetString()!;
        return expectedBase64 == storedBase64;
    }

    public static byte[] DeriveKey(string password)
    {
        using var sha256 = SHA256.Create();
        return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}
