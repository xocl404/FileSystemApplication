using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public interface ICommand
{
    string GetInfo();

    bool Execute(IFileSystem fileSystem);
}