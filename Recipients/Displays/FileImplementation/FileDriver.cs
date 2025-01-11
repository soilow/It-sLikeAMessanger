using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Displays.FileImplementation;

public class FileDriver : IFileDriver
{
    private readonly string _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DisplayMessages");

    public bool Output(IMessage message)
    {
        string txtPath = $"{_path}/{message.Title}.txt";

        try
        {
            CreateDirectory();
            File.WriteAllText(txtPath, message.Body);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }

        return true;
    }

    private void CreateDirectory()
    {
        if (!Directory.Exists(_path))
        {
            Directory.CreateDirectory(_path);
        }
    }
}