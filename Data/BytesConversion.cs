namespace ECNcloud.Data
{
    public static class BytesConversion
    {
        public static double BytesToKiB(double x)
        {
            return x / 1024;
        }
        
        public static double KiB(long x)
        {
            return x * 1024;
        }

        public static double MiB(long x)
        {
            return x * 1048576;
        }

        public static double GiB(long x)
        {
            return x * 1073741824;
        }
    }
}