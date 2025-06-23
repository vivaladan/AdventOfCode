namespace AdventOfCode2024.Tests;

public class Day1Tests
{
    [Fact]
    public void Day1Part1Sample()
    {
        Assert.Equal(11, Day1Code.Part1("Day1Sample.txt"));
    }
    
    [Fact]
    public void Day1Part1()
    {
        Assert.Equal(1320851, Day1Code.Part1("Day1Input.txt"));
    }
    
    [Fact]
    public void Day1Part2Sample()
    {
        Assert.Equal(31, Day1Code.Part2("Day1Sample.txt"));
    }
    
    [Fact]
    public void Day1Part2()
    {
        Assert.Equal(26859182, Day1Code.Part2("Day1Input.txt"));
    }
}