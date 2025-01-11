using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.GroupAddressees;

public class GroupAddressee : IAddressee
{
    private readonly HashSet<IAddressee> _addresses;

    public GroupAddressee()
    {
        _addresses = new HashSet<IAddressee>();
    }

    public void AddAddressee(IAddressee addressee)
    {
        _addresses.Add(addressee);
    }

    public void RemoveAddressee(IAddressee addressee)
    {
        _addresses.Remove(addressee);
    }

    public void SendMessage(IMessage message)
    {
        foreach (IAddressee addressee in _addresses)
        {
            addressee.SendMessage(message);
        }
    }
}