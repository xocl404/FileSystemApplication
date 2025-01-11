using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileDeleteCommand(string path) : ICommand
{
    public string GetInfo()
    {
        return $"This is a file delete command.\nPath = {path}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.FileDelete(path);
    }
}