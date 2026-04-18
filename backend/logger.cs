public static class Logger
{
    private static string logPath = "logs.txt";

    public static void Info(string message)
    {
        Log("INFO", message);
    }

    public static void Warning(string message)
    {
        Log("WARNING", message);
    }

    public static void Error(string message, Exception ex) 
    {
        Log("ERROR", message + " | " + ex.Message);
    }

    public static void Error(string message)
    {
        Log("ERROR", message);
    }

    private static void Log(string level, string message)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string entry = "[" + timestamp + "] [" + level + "] " + message;
        File.AppendAllText(logPath, entry + Environment.NewLine);
    }
}