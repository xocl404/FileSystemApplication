using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class FileCopyCommand(string sourcePath, string destinationPath) : ICommand
{
    public string GetInfo()
    {
        return $"This is a file copy command.\nSource path = {sourcePath}\nDestination path = {destinationPath}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.FileCopy(sourcePath, destinationPath);
    }
}