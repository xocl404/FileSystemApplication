namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class ConsoleShowFile : IShowFile
{
    public static void ShowFile(string path)
    {
        Console.WriteLine(File.ReadAllText(path));
    }
}