namespace AdventOfCode2024.Tests;

public class Day2Tests
{
    [Fact]
    public void Day2Part1Sample()
    {
        Assert.Equal(2, Day2Code.Part1("Day2Sample.txt"));
    }

    [Fact]
    public void Day2Part1()
    {
        Assert.Equal(686, Day2Code.Part1("Day2Input.txt"));
    }

    [Fact]
    public void Day2Part2Sample()
    {
        Assert.Equal(4, Day2Code.Part2("Day2Sample.txt"));
    }

    [Fact]
    public void Day2Part2()
    {
        Assert.Equal(717, Day2Code.Part2("Day2Input.txt"));
    }

    [Fact]
    public void Day2Part2_FirstElementBad()
    {
        // Real input from file that optimistic alg struggled with
        // Both have the first element as the bad one, but otherwise safe
        
        Assert.Equal(2, Day2Code.Part2(
        [
            new List<int> { 20, 17, 18, 21, 23, 25 },
            new List<int> { 84, 86, 85, 82, 81, 79, 76, 75 }
        ]));
    }
}