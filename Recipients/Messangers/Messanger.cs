using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Messangers;

public class Messanger : IMessanger
{
    public string Name { get; init; }

    public Messanger(string name)
    {
        Name = name;
    }

    public void GetMessage(IMessage message)
    {
        Console.WriteLine($"[Messanger {Name}]: {message.Body}");
    }
}