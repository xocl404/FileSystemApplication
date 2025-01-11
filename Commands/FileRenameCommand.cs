using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileRenameCommand(string path, string newName) : ICommand
{
    public string GetInfo()
    {
        return $"This is a file rename command.\nPath = {path}\nNew name = {newName}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.FileRename(path, newName);
    }
}