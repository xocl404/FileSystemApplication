using Itmo.ObjectOrientedProgramming.Lab4.Parser;
using Itmo.ObjectOrientedProgramming.Lab4.Parser.Handlers;
using Xunit;

namespace Lab4.Tests;

public class Test
{
    [Fact]
    public void ConnectCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "connect C:\\Users\\yarsi\\Desktop -m local";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a connect command.\nAddress = C:\\Users\\yarsi\\Desktop\nMode = local", commandInfo);
    }

    [Fact]
    public void DisconnectCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "disconnect";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a disconnect command.", commandInfo);
    }

    [Fact]
    public void TreeGoToCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "tree goto C:\\Users\\yarsi\\Desktop";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a tree goto command.\nAddress = C:\\Users\\yarsi\\Desktop", commandInfo);
    }

    [Fact]
    public void TreeListCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "tree list -d 3 -i ____ -fd ^ -dd $";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a tree list command.\nDepth = 3\nIndent = ____\nFileDesignation = ^\nDirectoryDesignation = $", commandInfo);
    }

    [Fact]
    public void FileShowCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "file show C:Users\\yarsi\\Desktop\\test.docx -m console";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a file show command.\nPath = C:Users\\yarsi\\Desktop\\test.docx\nMode = console", commandInfo);
    }

    [Fact]
    public void FileMoveCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "file move C:Users\\yarsi\\test.docx C:Users\\yarsi\\Desktop";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a file move command.\nSource path = C:Users\\yarsi\\test.docx\nDestination path = C:Users\\yarsi\\Desktop", commandInfo);
    }

    [Fact]
    public void FileCopyCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "file copy C:Users\\yarsi\\test.docx C:Users\\yarsi\\Desktop";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a file copy command.\nSource path = C:Users\\yarsi\\test.docx\nDestination path = C:Users\\yarsi\\Desktop", commandInfo);
    }

    [Fact]
    public void FileDeleteCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "file delete C:Users\\yarsi\\test.docx";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a file delete command.\nPath = C:Users\\yarsi\\test.docx", commandInfo);
    }

    [Fact]
    public void FileRenameCommandTest()
    {
        // Arrange
        ArgParser argParser = new ArgParserBuilder()
            .AddHandler(new DisconnectHandler())
            .AddHandler(new FileHandler())
            .AddHandler(new TreeHandler())
            .AddHandler(new ConnectHandler())
            .GetResult();
        string arguments = "file rename C:Users\\yarsi\\test.docx TEST.docx";

        // Act
        string commandInfo = argParser.ParseArguments(arguments.Split(" ")).GetInfo();

        // Assert
        Assert.Equal("This is a file rename command.\nPath = C:Users\\yarsi\\test.docx\nNew name = TEST.docx", commandInfo);
    }
}