using AdventOfCode.Year2022.Day7.Interfaces;
using AdventOfCode.Year2022.Day7.Models;
using AdventOfCode.Year2022.Day7.Services;

namespace AdventOfCode.Tests.Year2022.Day7.Services;

public class FileItemParserTests
{
    [Fact]
    public void Parse_WithValidFileNameAndSize_AddsFileAsCurrentNodeOffspring()
    {
        //Arrange
        var fileSize = 5626152;
        var fileName = "d.ext";
        var input = $"{fileSize} {fileName}";

        Node currentNode = new DirectoryNode("a")
        {
            Offsprings = new List<Node>
            {
                new FileNode("b.txt", 14848514),
                new FileNode("c.dat", 8504156)
            }
        };

        var expected = new FileNode(fileName, fileSize)
        {
            Parent = currentNode
        };

        ITerminalOutputParser parser = new FileItemParser(null);

        //Act
        parser.Parse(ref currentNode, input);

        //Assert
        ((DirectoryNode) currentNode).Offsprings.Should().ContainEquivalentOf(expected);
    }
}