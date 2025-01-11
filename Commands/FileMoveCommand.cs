using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileMoveCommand(string sourcePath, string destinationPath) : ICommand
{
    public string GetInfo()
    {
        return $"This is a file move command.\nSource path = {sourcePath}\nDestination path = {destinationPath}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.FileMove(sourcePath, destinationPath);
    }
}