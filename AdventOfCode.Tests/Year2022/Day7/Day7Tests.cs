using AdventOfCode.Year2022.Day7.Services;

namespace AdventOfCode.Tests.Year2022.Day7;

public class Day7Tests
{
    [Fact]
    public void GetSumOf100KAndLessDirectories_ReturnsSum()
    {
        //Arrange
        var input =
            $"$ cd /{Environment.NewLine}$ ls{Environment.NewLine}dir a{Environment.NewLine}14848514 b.txt{Environment.NewLine}8504156 c.dat{Environment.NewLine}dir d{Environment.NewLine}$ cd a{Environment.NewLine}$ ls{Environment.NewLine}dir e{Environment.NewLine}29116 f{Environment.NewLine}2557 g{Environment.NewLine}62596 h.lst{Environment.NewLine}$ cd e{Environment.NewLine}$ ls{Environment.NewLine}584 i{Environment.NewLine}$ cd ..{Environment.NewLine}$ cd ..{Environment.NewLine}$ cd d{Environment.NewLine}$ ls{Environment.NewLine}4060174 j{Environment.NewLine}8033020 d.log{Environment.NewLine}5626152 d.ext{Environment.NewLine}7214296 k{Environment.NewLine}";
        var mockInputFileService = new Mock<IInputFileService>();
        mockInputFileService
            .Setup(s => s.GetInputs(It.IsAny<string>(), null))
            .Returns(new[]
            {
                "$ cd /",
                "$ ls",
                "dir a",
                "14848514 b.txt",
                "8504156 c.dat",
                "dir d",
                "$ cd a",
                "$ ls",
                "dir e",
                "29116 f",
                "2557 g",
                "62596 h.lst",
                "$ cd e",
                "$ ls",
                "584 i",
                "$ cd ..",
                "$ cd ..",
                "$ cd d",
                "$ ls",
                "4060174 j",
                "8033020 d.log",
                "5626152 d.ext",
                "7214296 k"
            });

        var chain = new ChangeDirectoryParser(
            new ListDirectoryParser(new DirectoryItemParser(new FileItemParser(null))));

        var day7 = new AdventOfCode.Year2022.Day7.Day7(mockInputFileService.Object, chain);

        //Act
        var actual = day7.GetSumOf100KAndLessDirectories();

        //Assert
        actual.Should().Be(95437);
    }

    [Fact]
    public void GetDirectoryToDelete_WithFreeSpacePassedIn_ReturnsSum()
    {
        //Arrange
        var input =
            $"$ cd /{Environment.NewLine}$ ls{Environment.NewLine}dir a{Environment.NewLine}14848514 b.txt{Environment.NewLine}8504156 c.dat{Environment.NewLine}dir d{Environment.NewLine}$ cd a{Environment.NewLine}$ ls{Environment.NewLine}dir e{Environment.NewLine}29116 f{Environment.NewLine}2557 g{Environment.NewLine}62596 h.lst{Environment.NewLine}$ cd e{Environment.NewLine}$ ls{Environment.NewLine}584 i{Environment.NewLine}$ cd ..{Environment.NewLine}$ cd ..{Environment.NewLine}$ cd d{Environment.NewLine}$ ls{Environment.NewLine}4060174 j{Environment.NewLine}8033020 d.log{Environment.NewLine}5626152 d.ext{Environment.NewLine}7214296 k{Environment.NewLine}";
        var mockInputFileService = new Mock<IInputFileService>();
        mockInputFileService
            .Setup(s => s.GetInputs(It.IsAny<string>(), null))
            .Returns(new[]
            {
                "$ cd /",
                "$ ls",
                "dir a",
                "14848514 b.txt",
                "8504156 c.dat",
                "dir d",
                "$ cd a",
                "$ ls",
                "dir e",
                "29116 f",
                "2557 g",
                "62596 h.lst",
                "$ cd e",
                "$ ls",
                "584 i",
                "$ cd ..",
                "$ cd ..",
                "$ cd d",
                "$ ls",
                "4060174 j",
                "8033020 d.log",
                "5626152 d.ext",
                "7214296 k"
            });

        var chain = new ChangeDirectoryParser(
            new ListDirectoryParser(new DirectoryItemParser(new FileItemParser(null))));

        var day7 = new AdventOfCode.Year2022.Day7.Day7(mockInputFileService.Object, chain);

        //Act
        var actual = day7.GetDirectoryToDelete(30000000);

        //Assert
        actual.Should().Be(24933642);
    }
}