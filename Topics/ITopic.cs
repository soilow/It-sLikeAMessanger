using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public interface ITopic
{
    void SendMessage(IMessage message);

    void AddAddressee(IAddressee addressee);

    void RemoveAddressee(IAddressee addressee);
}