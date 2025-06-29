using AdventOfCode2024.Day2;

namespace AdventOfCode2024.Tests;

public class Day2
{
    [Fact]
    public void Part1Sample()
    {
        Assert.Equal(2, Code.Part1("Day2/Sample.txt"));
    }

    [Fact]
    public void Part1()
    {
        Assert.Equal(686, Code.Part1("Day2/Input.txt"));
    }

    [Fact]
    public void Part2Sample()
    {
        Assert.Equal(4, Code.Part2("Day2/Sample.txt"));
    }

    [Fact]
    public void Part2()
    {
        Assert.Equal(717, Code.Part2("Day2/Input.txt"));
    }

    [Fact]
    public void Part2_FirstElementBad()
    {
        // Real input from file that optimistic alg struggled with
        // Both have the first element as the bad one, but otherwise safe
        
        Assert.Equal(2, Code.Part2(
        [
            new List<int> { 20, 17, 18, 21, 23, 25 },
            new List<int> { 84, 86, 85, 82, 81, 79, 76, 75 }
        ]));
    }
}