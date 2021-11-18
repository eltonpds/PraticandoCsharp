using System;

namespace ExtensionMethods
{
    public static class DateTimeExtension
    {
        public static string ToBrazilianFormat(this DateTime value)
        {
            return value.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
