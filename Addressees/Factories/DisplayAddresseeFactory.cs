using Itmo.ObjectOrientedProgramming.Lab3.Addressees.Decorators;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees.DisplayAddresses;
using Itmo.ObjectOrientedProgramming.Lab3.Recipients.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factories;

public class DisplayAddresseeFactory : IAddresseeFactory
{
    private readonly IDisplay _display;

    public DisplayAddresseeFactory(IDisplay display)
    {
        _display = display;
    }

    public AddresseeBase Create(Importance messageImportanceThreshold)
    {
        return new FilterMessages(new Logger(new DisplayAddressee(_display)), messageImportanceThreshold);
    }
}