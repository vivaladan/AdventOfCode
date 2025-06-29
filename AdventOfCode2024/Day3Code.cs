namespace AdventOfCode2024;

public class Day3Code
{
    public static int Part1(string filename, bool obeyDoDont = false)
    {
        Load(filename, out var input);

        var data = input.AsSpan();
        var mulInstruction = "mul".AsSpan();
        var doInstruction = "do()".AsSpan();
        var dontInstruction = "don't()".AsSpan();
        
        var doState = true;
        var total = 0;

        for (var i = 0; i < data.Length;)
        {
            if (data[i..].StartsWith(doInstruction))
            { 
                i += doInstruction.Length;
                doState = true;
                continue;
            }
            
            if (data[i..].StartsWith(dontInstruction))
            { 
                i += dontInstruction.Length;
                doState = false;
                continue;
            }
            
            if (!data[i..].StartsWith(mulInstruction))
            {
                i++;
                continue;
            }

            // push past the instruction
            i += mulInstruction.Length;

            if (!data[i].Equals('('))
            {
                continue;
            }
            
            // push past opening '('
            i++; 

            var l = i;
            for (; l < data.Length; l++)
            {
                if (!char.IsDigit(data[l]))
                {
                    break;
                }
            }
            
            if (l == i)
            {
                // left operand is missing
                continue;
            }
            
            var leftOperand = int.Parse(data.Slice(i, l - i));

            // push past left operand
            i = l;

            if (data[i] != ',')
            {
                continue;
            }

            // push past ',' separator
            i++;
            
            var r = i;
            for (; r < data.Length; r++)
            {
                if (!char.IsDigit(data[r]))
                {
                    break;
                }
            }
            
            if (r == i)
            {
                // right operand is missing
                continue;
            }
            
            var rightOperand = int.Parse(data.Slice(i, r - i));
            
            // push past right operand
            i = r;
            
            if (data[i] != ')')
            {
                continue;
            }
            
            // push past closing ')'
            i++;

            if (!obeyDoDont || doState) total += leftOperand * rightOperand;
        }

        return total;
    }

    private static void Load(string filename, out string input)
    {
        input = string.Join("", File.ReadLines(filename));
    }

    public static int Part2(string filename)
    {
        return Part1(filename, true);
    }
}