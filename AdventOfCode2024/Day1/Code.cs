using System.Diagnostics;

namespace AdventOfCode2024.Day1;

public abstract class Code
{
    public static int Part1(string filename)
    {
        Load(filename, out var list1, out var list2);
        
        list1.Sort();
        list2.Sort();

        var score = 0;

        for (var i = 0; i < list1.Count; i++)
        {
            score += Math.Abs(list1[i] - list2[i]);
        }
        
        return score;
    }

    public static int Part2(string filename)
    {
        Load(filename, out var list1, out var list2);

        var score = 0;
        
        for (var i = 0; i < list1.Count; i++)
        {
            var target =  list1[i];

            var found = 0;
            
            for (var j = 0; j < list2.Count; j++)
            {
                if  (target == list2[j]) found++;
            }

            score += target * found;
        }

        return score;
    }
    
    
    

    private static void Load(string filename, out List<int> list1, out List<int> list2)
    {
        list1 = [];
        list2 = [];
        
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Debug.Assert(parts.Length == 2);
            
            list1.Add(int.Parse(parts[0]));
            list2.Add(int.Parse(parts[1]));
        }
        
        Debug.Assert(list1.Count == list2.Count);
    }
}