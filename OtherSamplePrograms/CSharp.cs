using System.Drawing;

public struct WaColor
{
    public struct Macha
    {
        public static Color Light   = Color.FromArgb(67, 178, 67);  // #43B243
        public static Color Normal  = Color.FromArgb(0, 119, 0);    // #007700
        public static Color Deep    = Color.FromArgb(0, 64, 0);     // #004000
    }

    public struct Azuki
    {
        public static Color Light   = Color.FromArgb(117, 0, 0);    // #750000
        public static Color Normal  = Color.FromArgb(135, 51, 51);  // #873333
        public static Color Deep    = Color.FromArgb(158, 67, 67);  // #9E4343
    }

    public struct Kinako
    {
        public static Color Light   = Color.FromArgb(150, 142, 0);  // #968E00
        public static Color Normal  = Color.FromArgb(183, 176, 33); // #B7B021
        public static Color Deep    = Color.FromArgb(216, 210, 82); // #D8D252
    }

    public struct Sora
    {
        public static Color Light   = Color.FromArgb(0, 99, 114);   // #006372
        public static Color Normal  = Color.FromArgb(0, 139, 160);  // #008BA0
        public static Color Deep    = Color.FromArgb(69, 186, 204); // #45BACC
    }
}
