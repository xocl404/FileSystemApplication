namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class FileComponent(string path) : IComponent
{
    public string Name { get; } = System.IO.Path.GetFileName(path);

    public string Path { get; } = path;
}