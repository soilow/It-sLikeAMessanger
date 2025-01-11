using Itmo.ObjectOrientedProgramming.Lab3.Recipients.Messangers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.MessangerAddressees;

public class MessangerAddressee : AddresseeBase
{
    public MessangerAddressee(IMessanger messanger) : base(messanger) { }
}