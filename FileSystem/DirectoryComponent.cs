using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class DirectoryComponent(string path) : IComponent
{
    public string Name { get; } = System.IO.Path.GetDirectoryName(path) ?? string.Empty;

    public string Path { get; } = path;

    public void TreeList(TreeListVisitor visitor)
    {
        IEnumerable<string> files = Directory.EnumerateFiles(Path);
        Collection<FileComponent> fileComponents = [];
        foreach (string file in files)
        {
            fileComponents.Add(new FileComponent(file));
        }

        visitor.Visit(fileComponents);
        IEnumerable<string> directories = Directory.EnumerateDirectories(Path);
        Collection<DirectoryComponent> directoryComponents = [];
        foreach (string directory in directories)
        {
            directoryComponents.Add(new DirectoryComponent(directory));
        }

        visitor.Visit(directoryComponents);
    }
}