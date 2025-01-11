using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Factories;

public interface IAddresseeFactory
{
    AddresseeBase Create(Importance messageImportanceThreshold);
}