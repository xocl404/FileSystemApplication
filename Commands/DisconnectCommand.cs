using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class DisconnectCommand : ICommand
{
    public string GetInfo()
    {
        return "This is a disconnect command.";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.Disconnect();
    }
}