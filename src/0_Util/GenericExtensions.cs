using System;

namespace _0_Util
{
    public static class GenericExtensions
    {
        public static void WriteToConsole(this string message, object arg0 = null)
        {
            string formatted = "";
            if (!string.IsNullOrWhiteSpace(message))
                formatted = message;
            if (arg0 != null)
                formatted = string.Format(message + "{0}", arg0);
            Console.WriteLine(formatted);
        }
    }

}
