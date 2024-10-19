using SOLID.OCP;
using SOLID.SRP;

#region SRP

//try
//{
//    Console.WriteLine("Please specify the file to convert to HTML.");
//    var filename = Console.ReadLine() ?? string.Empty;
//    var fileProcessor = new FileProcessor(filename);
//    var textProcessor = new TextProcessor(fileProcessor);

//    textProcessor.ConvertText();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion

#region OCP

try
{
    Console.WriteLine("Please specify the file to convert to HTML.");

    var filename = Console.ReadLine();
    var fileProcessor = new SOLID.OCP.FileProcessor(filename);

    var tagsToReplace = new Dictionary<string, (string, string)>
    {
        { "**", ("<em>", "</em>") },
        { "*", ("<strong>", "</strong>") },
        { "~~", ("<del>", "</del>") }
    };

    var textProcessor = new MdTextProcessor(tagsToReplace);
    var inputText = fileProcessor.ReadAllText();
    var outputText = textProcessor.ConvertText(inputText);

    fileProcessor.WriteToFile(outputText);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

#endregion