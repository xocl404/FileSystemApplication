using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class ConnectHandler : HandlerBase
{
    public override ICommand Handle(IEnumerator<string> args)
    {
        if (args.Current is not "connect") return Next?.Handle(args) ?? new NoCommand();
        if (args.MoveNext() is false) return new NoCommand();
        string address = args.Current;
        if (args.MoveNext() is false) return new NoCommand();
        if (args.Current is not "-m") return new NoCommand();
        if (args.MoveNext() is false) return new NoCommand();
        string mode = args.Current;
        return new ConnectCommand(address, mode);
    }
}