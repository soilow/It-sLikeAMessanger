using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Displays.DisplayImplementation;

public interface IDisplayDriver : IDisplayRenderer
{
    void ClearConsole();

    void SetOutputColor(Color color);
}