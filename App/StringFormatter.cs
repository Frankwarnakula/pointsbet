using System.Text;

namespace PointsBet.Backend.Online.Code
{
    public class StringFormatter
    {
        public static string ToCommaSepatatedList(string[] items, string quote)
        {

            // If the array contains a single empty string, return empty string
            if (items.Length == 1 && items[0] == string.Empty)
                return string.Empty;

            return string.Join(", ", items.Select(item => string.Concat(quote, item, quote)));
        }
    }
}
