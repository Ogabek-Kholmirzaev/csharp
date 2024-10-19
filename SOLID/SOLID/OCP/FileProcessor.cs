using System.Web;

namespace SOLID.OCP;

public class FileProcessor
{
    private readonly string filename;

    public FileProcessor(string filename)
    {
        this.filename = filename;
    }

    public string ReadAllText()
    {
        var fullPath = Path.Combine(GetProjectDirectory(), this.filename);

        return HttpUtility.HtmlAttributeEncode(File.ReadAllText(fullPath));
    }

    public void WriteToFile(string text)
    {
        var outputFilePath = Path.Combine(GetProjectDirectory(), $"{Path.GetFileNameWithoutExtension(this.filename)}.html");
        using var file = new StreamWriter(outputFilePath);

        file.Write(text);
    }

    public string GetProjectDirectory()
    {
        return Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
    }
}
