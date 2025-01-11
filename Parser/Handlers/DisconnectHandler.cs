using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public class DisconnectHandler : HandlerBase
{
    public override ICommand Handle(IEnumerator<string> args)
    {
        if (args.Current is not "disconnect") return Next?.Handle(args) ?? new NoCommand();
        return new DisconnectCommand();
    }
}