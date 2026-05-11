public static class ThemeColors
{
    public static bool IsDarkMode { get; set; } = true;

    public static Color BgPrimary => Get(0x0F1117, 0xF5F7FA);
    public static Color BgSurface => Get(0x161921, 0xFFFFFF);
    public static Color BgCard => Get(0x24242A, 0xFFFFFF);
    public static Color BgInput => Get(0x32323A, 0xFFFFFF);
    public static Color BgInputAlt => Get(0x1E2130, 0xF5F7FA);
    public static Color BorderColor => Get(0x1E2130, 0xD1D5DB);
    public static Color TextBright => Get(0xD1D5DB, 0x111827);
    public static Color TextMuted => Get(0x9CA3AF, 0x6B7280);
    public static Color TextLabel => Get(0xAAAAB4, 0x374151);
    public static Color TextPlaceholder => Get(0x8C8C96, 0x9CA3AF);
    public static Color AccentBlue => Color.FromArgb(58, 130, 246);
    public static Color AccentGreen => Color.FromArgb(22, 163, 74);
    public static Color AccentRed => Color.FromArgb(220, 38, 38);

    private static Color Get(int darkRgb, int lightRgb)
    {
        int rgb = IsDarkMode ? darkRgb : lightRgb;
        return Color.FromArgb((rgb >> 16) & 0xFF, (rgb >> 8) & 0xFF, rgb & 0xFF);
    }
}
