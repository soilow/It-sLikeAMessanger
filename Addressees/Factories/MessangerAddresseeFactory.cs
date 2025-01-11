using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Decorators;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.MessangerAddressees;
using Itmo.ObjectOrientedProgramming.Lab3.Recipients.Messangers;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factories;

public class MessangerAddresseeFactory : IAddresseeFactory
{
    private readonly IMessanger _messanger;

    public MessangerAddresseeFactory(IMessanger messanger)
    {
        _messanger = messanger;
    }

    public AddresseeBase Create(Importance messageImportanceThreshold)
    {
        return new FilterMessages(new Logger(new MessangerAddressee(_messanger)), messageImportanceThreshold);
    }
}