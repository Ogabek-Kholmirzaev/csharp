using System.Text.RegularExpressions;
using System.Text;

namespace SOLID.OCP;

public class TextProcessor
{
    public virtual string ConvertText(string inputText)
    {
        var paragraphs = Regex.Split(inputText, @"(\r\n?|\n)").Where(p => p.Any(char.IsLetterOrDigit));
        var stringBuilder = new StringBuilder();

        foreach (var paragraph in paragraphs)
        {
            if (paragraph.Length == 0)
            {
                continue;
            }

            stringBuilder.AppendLine($"<p>{paragraph}</p>");
        }

        stringBuilder.AppendLine("<br/>");

        return stringBuilder.ToString();
    }
}
