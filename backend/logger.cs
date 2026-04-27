/// <summary>
/// File-based logging utility that appends timestamped log entries to logs.txt.
/// Log entries follow the format: [yyyy-MM-dd HH:mm:ss] [LEVEL] message.
///
/// Notes:
///     - All log methods are thread-safe due to static File.AppendAllText.
///     - The log file is created in the application's current working directory.
///     - Error entries include exception messages when an Exception overload is used.
/// </summary>
public static class Logger
{
    private static string logPath = "logs.txt";

    /// <summary>
    /// Writes an informational log entry. Use for general operational messages
    /// such as account creation, deletion, and successful operations.
    ///
    /// Args:
    ///     message: The informational message to log.
    /// </summary>
    public static void Info(string message)
    {
        Log("INFO", message);
    }

    /// <summary>
    /// Writes a warning log entry. Use for non-critical issues that may require
    /// attention but do not prevent the application from functioning.
    ///
    /// Args:
    ///     message: The warning message to log.
    /// </summary>
    public static void Warning(string message)
    {
        Log("WARNING", message);
    }

    /// <summary>
    /// Writes an error log entry that includes exception details. The exception
    /// message is appended after the provided message separated by a pipe.
    ///
    /// Args:
    ///     message: A human-readable description of the operation that failed.
    ///     ex: The exception whose message will be included in the log entry.
    /// </summary>
    public static void Error(string message, Exception ex)
    {
        Log("ERROR", message + " | " + ex.Message);
    }

    /// <summary>
    /// Writes an error log entry without an associated exception. Use when
    /// an error condition is detected programmatically rather than caught.
    ///
    /// Args:
    ///     message: The error message to log.
    /// </summary>
    public static void Error(string message)
    {
        Log("ERROR", message);
    }

    /// <summary>
    /// Core logging method that formats and appends a timestamped entry to
    /// the log file. All public log methods delegate to this private method.
    ///
    /// Args:
    ///     level: The log level string (INFO, WARNING, ERROR).
    ///     message: The pre-formatted log message content.
    /// </summary>
    private static void Log(string level, string message)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string entry = "[" + timestamp + "] [" + level + "] " + message;
        File.AppendAllText(logPath, entry + Environment.NewLine);
    }
}
