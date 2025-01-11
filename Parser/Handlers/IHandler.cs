using Itmo.ObjectOrientedProgramming.Lab4.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;

public interface IHandler
{
    IHandler AddNext(IHandler handler);

    ICommand Handle(IEnumerator<string> args);
}