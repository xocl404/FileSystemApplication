using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class LocalFileSystem : IFileSystem
{
    private string? _currentDirectory;

    private string? _currentTreeDirectory;

    public bool Connect(string address, string mode)
    {
        if (mode is not "local") return false;
        _currentDirectory = address;
        return true;
    }

    public bool Disconnect()
    {
        if (_currentDirectory is null) return false;
        _currentDirectory = null;
        return true;
    }

    public bool TreeGoTo(string address)
    {
        if (_currentDirectory is null) return false;
        _currentTreeDirectory = address;
        return true;
    }

    public bool TreeList(TreeListVisitor visitor)
    {
        if (_currentDirectory is null) return false;
        if (_currentTreeDirectory is null) return false;
        Collection<DirectoryComponent> directoryComponents =
            [
                new(PathChanger.CastRelativeToAbsolute(_currentDirectory, _currentTreeDirectory))
            ];
        visitor.Visit(directoryComponents);
        return true;
    }

    public bool FileShow(string path, string mode)
    {
        if (_currentDirectory is null) return false;
        path = PathChanger.CastRelativeToAbsolute(_currentDirectory, path);
        if (File.Exists(path) is false) return false;
        if (mode is not "console") return false;
        ConsoleShowFile.ShowFile(path);
        return true;
    }

    public bool FileMove(string sourcePath, string destinationPath)
    {
        if (_currentDirectory is null) return false;
        sourcePath = PathChanger.CastRelativeToAbsolute(_currentDirectory, sourcePath);
        destinationPath = PathChanger.CastRelativeToAbsolute(_currentDirectory, destinationPath);
        if (File.Exists(sourcePath) is false) return false;
        File.Move(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
        return true;
    }

    public bool FileCopy(string sourcePath, string destinationPath)
    {
        if (_currentDirectory is null) return false;
        sourcePath = PathChanger.CastRelativeToAbsolute(_currentDirectory, sourcePath);
        destinationPath = PathChanger.CastRelativeToAbsolute(_currentDirectory, destinationPath);
        if (File.Exists(sourcePath) is false) return false;
        File.Copy(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));
        return true;
    }

    public bool FileDelete(string path)
    {
        if (_currentDirectory is null) return false;
        path = PathChanger.CastRelativeToAbsolute(_currentDirectory, path);
        if (File.Exists(path) is false) return false;
        File.Delete(path);
        return true;
    }

    public bool FileRename(string path, string newName)
    {
        if (_currentDirectory is null) return false;
        path = PathChanger.CastRelativeToAbsolute(_currentDirectory, path);
        if (File.Exists(path) is false) return false;
        string directory = Path.GetDirectoryName(path) ?? string.Empty;
        string newPath = Path.Combine(directory, newName);
        File.Move(path, newPath);
        return true;
    }
}
