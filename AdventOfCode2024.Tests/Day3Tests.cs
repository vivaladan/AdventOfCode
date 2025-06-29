namespace AdventOfCode2024.Tests;

public class Day3Tests
{
    [Fact]
    public void Day3Part1Sample()
    {
        Assert.Equal(161, Day3Code.Part1("Day3Sample.txt"));
    }

    [Fact]
    public void Day3Part1()
    {
        Assert.Equal(178886550, Day3Code.Part1("Day3Input.txt"));
    }
    
    [Fact]
    public void Day3Part2Sample()
    {
        Assert.Equal(48, Day3Code.Part2("Day3Part2Sample.txt"));
    }
    
    [Fact]
    public void Day3Part2()
    {
        Assert.Equal(87163705, Day3Code.Part2("Day3Input.txt"));
    }
}