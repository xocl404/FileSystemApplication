using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class ArgParser(IHandler handler)
{
    public ICommand ParseArguments(IEnumerable<string> arguments)
    {
        using IEnumerator<string> args = arguments.GetEnumerator();
        return !args.MoveNext() ? new NoCommand() : handler.Handle(args);
    }
}