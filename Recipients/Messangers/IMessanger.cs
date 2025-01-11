namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Messangers;

public interface IMessanger : IRecipient
{
    string Name { get; }
}