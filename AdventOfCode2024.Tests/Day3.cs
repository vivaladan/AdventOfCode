using AdventOfCode2024.Day3;

namespace AdventOfCode2024.Tests;

public class Day3
{
    [Fact]
    public void Part1Sample()
    {
        Assert.Equal(161, Code.Part1("Day3/Sample1.txt"));
    }

    [Fact]
    public void Part1()
    {
        Assert.Equal(178886550, Code.Part1("Day3/Input.txt"));
    }
    
    [Fact]
    public void Part2Sample()
    {
        Assert.Equal(48, Code.Part2("Day3/Sample2.txt"));
    }
    
    [Fact]
    public void Part2()
    {
        Assert.Equal(87163705, Code.Part2("Day3/Input.txt"));
    }
}