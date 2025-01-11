using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Displays.DisplayImplementation;

public class DisplayDriver : IDisplayDriver
{
    private Color _color = Color.Black;

    public void SetOutputColor(Color color)
    {
        _color = color;
    }

    public void ClearConsole()
    {
        Console.Clear();
    }

    public bool Output(IMessage message)
    {
        string formattedMessage = FormatMessageWithColor(message);

        ClearConsole();
        Console.WriteLine(formattedMessage);

        return true;
    }

    private string FormatMessageWithColor(IMessage message)
    {
        return Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(message.Body);
    }
}