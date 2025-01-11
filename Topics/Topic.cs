using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public class Topic : ITopic
{
    public string Name { get; init; }

    private readonly HashSet<IAddressee> _addressees;

    public Topic(string name)
    {
        Name = name;
        _addressees = new HashSet<IAddressee>();
    }

    public void AddAddressee(IAddressee addressee)
    {
        _addressees.Add(addressee);
    }

    public void RemoveAddressee(IAddressee addressee)
    {
        _addressees.Remove(addressee);
    }

    public void SendMessage(IMessage message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            addressee.SendMessage(message);
        }
    }
}