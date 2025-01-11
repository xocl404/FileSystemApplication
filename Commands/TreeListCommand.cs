using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class TreeListCommand(int depth, string indent, string fileDesignation, string directoryDesignation) : ICommand
{
    public string GetInfo()
    {
        return $"This is a tree list command.\nDepth = {depth}\nIndent = {indent}\nFileDesignation = {fileDesignation}\nDirectoryDesignation = {directoryDesignation}";
    }

    public bool Execute(IFileSystem fileSystem)
    {
        return fileSystem.TreeList(new TreeListVisitor(depth, indent, fileDesignation, directoryDesignation));
    }
}