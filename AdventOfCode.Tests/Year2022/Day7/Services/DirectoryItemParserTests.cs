using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;
using AdventOfCode.Year2022.Day7.Services;

namespace AdventOfCode.Tests.Year2022.Day7.Services;

public class DirectoryItemParserTests
{
    [Fact]
    public void Parse_WithValidDirectoryName_AddsDirectoryAsCurrentNodeOffspring()
    {
        //Arrange
        Node currentNode = new DirectoryNode("a")
        {
            Offsprings = new List<Node>
            {
                new FileNode("b.txt", 14848514),
                new FileNode("c.dat", 8504156)
            }
        };

        var expected = new DirectoryNode("d")
        {
            Parent = currentNode
        };

        ITerminalOutputParser parser = new DirectoryItemParser(null);

        //Act
        parser.Parse(ref currentNode, "dir d");

        //Assert
        ((DirectoryNode) currentNode).Offsprings.Should().ContainEquivalentOf(expected);
    }
}