class Programm
{
    static void Main()
    {
        string filePath = Console.ReadLine();

        string fileName = String.Empty;
        string fileExtension = String.Empty;

        int lastSeparatorIndex = filePath.LastIndexOf('\\');
        int lastExtensionIndex = filePath.LastIndexOf(".");

        if (lastSeparatorIndex != -1 && lastExtensionIndex != -1 && lastExtensionIndex > lastSeparatorIndex)
        {
            fileName = filePath.Substring(lastSeparatorIndex + 1, lastExtensionIndex - lastSeparatorIndex - 1);
            fileExtension = filePath.Substring(lastExtensionIndex + 1);
        }

        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extension: {fileExtension}");
    }

}