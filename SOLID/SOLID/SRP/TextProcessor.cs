using System.Text;
using System.Text.RegularExpressions;

namespace SOLID.SRP;

public class TextProcessor
{
    private readonly FileProcessor fileProcessor;

    public TextProcessor(FileProcessor fileProcessor)
    {
        this.fileProcessor = fileProcessor;
    }

    public void ConvertText()
    {
        var inputText = this.fileProcessor.ReadAllText();

        Console.WriteLine(inputText);

        var paragraphs = Regex.Split(inputText, @"(\r\n?|\n)").Where(x => x.Any(char.IsLetterOrDigit));
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
        this.fileProcessor.WriteToFile(stringBuilder.ToString());
    }
}
