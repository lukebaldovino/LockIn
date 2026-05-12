public static class Tests
{
    public static void Run()
    {
        MasterAccount.Save("admin", "password");
        var (_, key) = MasterAccount.Load()!.Value;
        UtilityFunctions.Initialize(key);
        UtilityFunctions.CreateAccount(
            "github",
            "user@example.com",
            "fff",
            AccountType.Personal
            );
    }
}