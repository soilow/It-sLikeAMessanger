using Itmo.ObjectOrientedProgramming.Lab3.Recipients.Users;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.UserAddressees;

public class UserAddressee : AddresseeBase
{
    public UserAddressee(IUser user) : base(user) { }
}