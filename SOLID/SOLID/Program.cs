using System.Text;
using System.Text.RegularExpressions;
using System.Web;

try
{
    Console.WriteLine("Please specify the full file path to convet to HTML.");

    var filename = Console.ReadLine() ?? string.Empty;
    var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

    Console.WriteLine($"{projectDirectory}");

    var fullFilePath = Path.Combine(projectDirectory, filename);

    var inputText = ReadAllText(fullFilePath);

    Console.WriteLine($"\n{inputText}\n");

    var paragraphs = Regex.Split(inputText, @"(\r\n?|\n)")
        .Where(x => x.Any(char.IsLetterOrDigit));

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
    WriteToFile(projectDirectory, filename, stringBuilder.ToString());
}
catch(Exception exception)
{
    Console.WriteLine(exception.Message);
}

string ReadAllText(string fullFilePath)
{
    return HttpUtility.HtmlEncode(File.ReadAllText(fullFilePath));
}

void WriteToFile(string projectDirectory, string fileName, string text)
{
    var outputFilePath = Path.Combine(projectDirectory, $"{Path.GetFileNameWithoutExtension(fileName)}.html");

    Console.WriteLine(outputFilePath);

    using StreamWriter file = new StreamWriter(outputFilePath);
    file.Write(text);
}