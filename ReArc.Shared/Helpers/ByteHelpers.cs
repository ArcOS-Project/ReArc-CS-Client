namespace ReArc.Shared.Helpers
{
    public static class ByteHelpers
    {
        private static readonly string[] _sizeUnits = ["bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"];
        public static string FormatBytes(double bytes)
        {
            var l = 0;
            var n = bytes;

            while (n >= 1024 && ++l > 0)
            {
                n /= 1024;
            }

            return $"{n.ToString("F" + (n < 10 && l > 0 ? 1 : 0))} {_sizeUnits[l]}";
        }
    }
}
