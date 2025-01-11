using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class NoCommand : ICommand
{
    public string GetInfo()
    {
        return "This is a no command.";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return false;
    }
}