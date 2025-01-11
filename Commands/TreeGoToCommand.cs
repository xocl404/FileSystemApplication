using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class TreeGoToCommand(string address) : ICommand
{
    public string GetInfo()
    {
        return $"This is a tree goto command.\nAddress = {address}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.TreeGoTo(address);
    }
}