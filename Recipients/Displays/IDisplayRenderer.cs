using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Displays;

public interface IDisplayRenderer
{
    bool Output(IMessage message);
}