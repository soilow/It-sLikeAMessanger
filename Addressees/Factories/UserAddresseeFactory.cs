using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Decorators;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.UserAddressees;
using Itmo.ObjectOrientedProgramming.Lab3.Recipients.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factories;

public class UserAddresseeFactory : IAddresseeFactory
{
    private readonly IUser _user;

    public UserAddresseeFactory(IUser user)
    {
        _user = user;
    }

    public AddresseeBase Create(Importance messageImportanceThreshold)
    {
        return new FilterMessages(new Logger(new UserAddressee(_user)), messageImportanceThreshold);
    }
}