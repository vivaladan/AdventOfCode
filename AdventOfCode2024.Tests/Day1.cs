using AdventOfCode2024.Day1;

namespace AdventOfCode2024.Tests;

public class Day1
{
    [Fact]
    public void Part1Sample()
    {
        Assert.Equal(11, Code.Part1("Day1/Sample.txt"));
    }
    
    [Fact]
    public void Part1()
    {
        Assert.Equal(1320851, Code.Part1("Day1/Input.txt"));
    }
    
    [Fact]
    public void Part2Sample()
    {
        Assert.Equal(31, Code.Part2("Day1/Sample.txt"));
    }
    
    [Fact]
    public void Part2()
    {
        Assert.Equal(26859182, Code.Part2("Day1/Input.txt"));
    }
}