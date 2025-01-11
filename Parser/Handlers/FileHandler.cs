using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class FileHandler : HandlerBase
{
    public override ICommand Handle(IEnumerator<string> args)
    {
        if (args.Current is not "file") return Next?.Handle(args) ?? new NoCommand();
        if (args.MoveNext() is false) return new NoCommand();
        if (args.Current is "show")
        {
            if (args.MoveNext() is false) return new NoCommand();
            string path = args.Current;
            if (args.MoveNext() is false) return new NoCommand();
            if (args.Current is not "-m") return new NoCommand();
            if (args.MoveNext() is false) return new NoCommand();
            string mode = args.Current;
            return new FileShowCommand(path, mode);
        }

        if (args.Current is "move" or "copy")
        {
            string current = args.Current;
            if (args.MoveNext() is false) return new NoCommand();
            string sourcePath = args.Current;
            if (args.MoveNext() is false) return new NoCommand();
            string destinationPath = args.Current;
            if (current == "move") return new FileMoveCommand(sourcePath, destinationPath);
            return new FileCopyCommand(sourcePath, destinationPath);
        }

        if (args.Current is "delete")
        {
            return args.MoveNext() is false ? new NoCommand() : new FileDeleteCommand(args.Current);
        }

        if (args.Current is "rename")
        {
            if (args.MoveNext() is false) return new NoCommand();
            string path = args.Current;
            if (args.MoveNext() is false) return new NoCommand();
            string name = args.Current;
            return new FileRenameCommand(path, name);
        }

        return new NoCommand();
    }
}