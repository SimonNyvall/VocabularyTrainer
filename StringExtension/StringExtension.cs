using System.Text;

namespace VocabularyTrainer
{
    public static class StringExtension
    {
        public static string ToTitel(this string text)
        {
            var returnValue = new StringBuilder();
            returnValue.Append(text[0].ToString().ToUpper());
            returnValue.Append(text.Substring(1).ToLower());
            return returnValue.ToString();
        }
    }
}