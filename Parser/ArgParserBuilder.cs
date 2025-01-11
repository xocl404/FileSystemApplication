using Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser;

public class ArgParserBuilder
{
    private IHandler? _handler;

    public ArgParserBuilder AddHandler(IHandler handler)
    {
        if (_handler is null) _handler = handler;
        else _handler.AddNext(handler);
        return this;
    }

    public ArgParser GetResult()
    {
        if (_handler is null) throw new Exception("Handler is null");
        return new ArgParser(_handler);
    }
}