using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;
using AdventOfCode.Year2022.Day7.Services;

namespace AdventOfCode.Tests.Year2022.Day7.Services;

public class ChangeDirCommandProcessorTests
{
    [Fact]
    public void Parse_WithValidDirectoryName_ChangesCurrentNodeToThatDirectory()
    {
        //Arrange
        var directoryA = new DirectoryNode("a")
        {
            Offsprings = new List<Node>
            {
                new FileNode("b.txt", 14848514),
                new FileNode("c.dat", 8504156)
            }
        };

        Node currentNode = new DirectoryNode("/")
        {
            Offsprings = new List<Node>
            {
                directoryA,
                new FileNode("a.txt", 62596)
            }
        };


        ITerminalOutputParser parser = new ChangeDirectoryParser(null);

        //Act
        parser.Parse(ref currentNode, "$ cd a");

        //Assert
        currentNode.Should().BeEquivalentTo(directoryA);
    }

    [Fact]
    public void Parse_WithDotDot_ChangesCurrentNodeToParent()
    {
        //Arrange
        Node currentDirectory = new DirectoryNode("a")
        {
            Offsprings = new List<Node>
            {
                new FileNode("b.txt", 14848514),
                new FileNode("c.dat", 8504156)
            }
        };

        var parentDirectory = new DirectoryNode("/")
        {
            Offsprings = new List<Node>
            {
                currentDirectory,
                new FileNode("a.txt", 62596)
            }
        };

        currentDirectory.Parent = parentDirectory;


        ITerminalOutputParser parser = new ChangeDirectoryParser(null);

        //Act
        parser.Parse(ref currentDirectory, "$ cd ..");

        //Assert
        currentDirectory.Should().BeEquivalentTo(parentDirectory);
    }
}