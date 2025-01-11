namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public class PathChanger
{
    public static string CastRelativeToAbsolute(string directoryPath, string relativePath)
    {
        return Path.Combine(directoryPath, relativePath);
    }
}