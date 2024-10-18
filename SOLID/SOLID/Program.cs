using SOLID.SRP;

#region SRP

try
{
    Console.WriteLine("Please specify the file to convert to HTML.");
    var filename = Console.ReadLine() ?? string.Empty;
    var fileProcessor = new FileProcessor(filename);
    var textProcessor = new TextProcessor(fileProcessor);

    textProcessor.ConvertText();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

#endregion