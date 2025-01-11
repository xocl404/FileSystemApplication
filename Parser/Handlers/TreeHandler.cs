using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class TreeHandler : HandlerBase
{
    public override ICommand Handle(IEnumerator<string> args)
    {
        if (args.Current is not "tree") return Next?.Handle(args) ?? new NoCommand();
        if (args.MoveNext() is false) return new NoCommand();
        if (args.Current is "goto")
        {
            if (args.MoveNext() is false) return new NoCommand();
            return new TreeGoToCommand(args.Current);
        }

        if (args.Current is "list")
        {
            int depth = 1;
            string indent = "   ";
            string fileDesignation = "->";
            string directoryDesignation = "<>";
            while (args.MoveNext())
            {
                if (args.Current is "-d")
                {
                    if (args.MoveNext() is false) break;
                    depth = Convert.ToInt32(args.Current);
                }
                else if (args.Current is "-i")
                {
                    if (args.MoveNext() is false) break;
                    indent = args.Current;
                }
                else if (args.Current is "-fd")
                {
                    if (args.MoveNext() is false) break;
                    fileDesignation = args.Current;
                }
                else if (args.Current is "-dd")
                {
                    if (args.MoveNext() is false) break;
                    directoryDesignation = args.Current;
                }
            }

            return new TreeListCommand(depth, indent, fileDesignation, directoryDesignation);
        }

        return new NoCommand();
    }
}