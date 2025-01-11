using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class TreeListVisitor(int maxDepth, string indent, string fileDesignation, string directoryDesignation)
{
    private int _currentDepth;

    public void Visit(Collection<FileComponent> fileComponents)
    {
        foreach (FileComponent file in fileComponents)
        {
            ConsolePrintFile(file.Name);
        }
    }

    public void Visit(Collection<DirectoryComponent> directoryComponents)
    {
        foreach (DirectoryComponent directory in directoryComponents)
        {
            ConsolePrintDirectory(directory.Name);
            ++_currentDepth;
            if (_currentDepth <= maxDepth) directory.TreeList(this);
            --_currentDepth;
        }
    }

    private void ConsolePrintFile(string file)
    {
        Console.Write(string.Concat(Enumerable.Repeat(indent, _currentDepth)));
        Console.Write(fileDesignation);
        Console.WriteLine(file);
    }

    private void ConsolePrintDirectory(string directory)
    {
        Console.Write(string.Concat(Enumerable.Repeat(indent, _currentDepth)));
        Console.Write(directoryDesignation);
        Console.WriteLine(directory);
    }
}