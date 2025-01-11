using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileShowCommand(string path, string mode) : ICommand
{
    public string GetInfo()
    {
        return $"This is a file show command.\nPath = {path}\nMode = {mode}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.FileShow(path, mode);
    }
}