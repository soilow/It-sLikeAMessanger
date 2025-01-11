using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Displays;

public class Display : IDisplay
{
    private readonly IDisplayRenderer _displayImplemention;
    private IMessage? _message;

    public Display(IDisplayRenderer displayImplemention)
    {
        _displayImplemention = displayImplemention;
    }

    public void GetMessage(IMessage message)
    {
        _message = message;
    }

    public bool Output()
    {
        if (_message is null)
        {
            return false;
        }

        _displayImplemention.Output(_message);

        return true;
    }
}