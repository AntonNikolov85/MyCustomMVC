namespace CustomMVC.Extensions
{
    public static class StringExtensions
    {
        public static string ToUpperFirst(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
