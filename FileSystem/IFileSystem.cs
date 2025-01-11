namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public interface IFileSystem
{
    bool Connect(string address, string mode);

    bool Disconnect();

    bool TreeGoTo(string address);

    bool TreeList(TreeListVisitor visitor);

    bool FileShow(string path, string mode);

    bool FileMove(string sourcePath, string destinationPath);

    bool FileCopy(string sourcePath, string destinationPath);

    bool FileDelete(string path);

    bool FileRename(string path, string newName);
}