namespace CF.Common.Tools
{
    public class CharUtility
    {
        public static string Replace(string text)
        {
            text = text.Replace("ı", "i");
            text = text.Replace("ğ", "g");
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ç", "c");
            text = text.Replace("-", "_");
            text = text.Replace(".", "_");
            text = text.Replace("/", "_");
            text = text.Replace(",", "_");
            text = text.Replace("&", "_");
            text = text.Replace("%", "_");
            text = text.Replace("(", "_");
            text = text.Replace(")", "_");
            text = text.Replace("*", "_");
            text = text.Replace("?", "_");
            text = text.Replace("#", "_");
            text = text.Replace(" ", "_");

            return text;
        }
    }
}
