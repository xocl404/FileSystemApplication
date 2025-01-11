using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class ConnectCommand(string address, string mode) : ICommand
{
    public string GetInfo()
    {
        return $"This is a connect command.\nAddress = {address}\nMode = {mode}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.Connect(address, mode);
    }
}