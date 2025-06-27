using System.Diagnostics;
using System.Security.Cryptography;

namespace AdventOfCode2024;

public class Day2Code
{
    public static int Part1(string filename)
    {
        Load(filename, out var reports);

        var safeReports = 0;

        foreach (var report in reports)
        {
            Debug.Assert(reports.Count > 2);

            var increasing = report[0] < report[1];
            var previous = report[0];

            var isUnsafe = false;

            for (var i = 1; i < report.Count; i++)
            {
                var current = report[i];

                if (
                    // 1 3 6 7 9
                    (increasing && current > previous && current <= previous + 3) ||
                    // 7 6 4 2 1
                    !increasing && current < previous && current >= previous - 3)
                {
                    previous = current;
                    continue;
                }


                isUnsafe = true;
                break;
            }

            if (!isUnsafe) safeReports++;
        }

        return safeReports;
    }

    public static int Part2(List<List<int>> reports)
    {
        int safeReports = 0;
        
        foreach (var report in reports)
        {
            Debug.Assert(report.Count > 2);


            if (IsSafe(report, out var index))
            {
                safeReports++;
            }
            else
            {
                // !!** apply dampener to see if removing one element makes it safe
                
                // ** brute force by removing each element one by one

                // for (var i = 0; i < report.Count; i++)
                // {
                //     var modifiedReport = report.ToList();
                //     modifiedReport.RemoveAt(i);
                //
                //     if (IsSafe(modifiedReport, out _))
                //     {
                //         safeReports++;
                //         break;
                //     }
                // }

                // ** optimistically remove either element at first failure
                
                // if first element in range but implies different direction than rest of range
                // IsSafe will return index 2 because second comparison fails direction
                // always test without first element first
                var withoutFirstIndex = report.ToList();
                withoutFirstIndex.RemoveAt(0);
                if (IsSafe(withoutFirstIndex, out _))
                {
                    safeReports++;
                    continue;
                }

                // try without the first element of the comparison that failed
                var withoutPreviousIndex = report.ToList();
                withoutPreviousIndex.RemoveAt(index-1);
                if (IsSafe(withoutPreviousIndex, out _))
                {
                    safeReports++;
                    continue;
                }

                // try without the second element of the comparison that failed
                var withoutCurrentIndex = report.ToList();
                withoutCurrentIndex.RemoveAt(index);
                if (IsSafe(withoutCurrentIndex, out _))
                {
                    safeReports++;
                    continue;
                }
            }

        }
        
        return safeReports;
    }
    
    public static int Part2(string filename)
    {
        Load(filename, out var reports);

        return Part2(reports);
    }

    private static bool IsSafe(IReadOnlyList<int> report, out int index)
    {
        var increasing = report[0] < report[1];

        for (var i = 1; i < report.Count; i++)
        {
            var diff = report[i] - report[i - 1];

            if ((Math.Abs(diff) < 1 || Math.Abs(diff) > 3))
            {
                index = i;
                return false; // unsafe
            }

            if ((increasing && diff < 0) || (!increasing && diff > 0))
            {
                index = i;
                return false; // unsafe
            }
        }

        index = -1;
        return true; // safe
    }

    private static void Load(string filename, out List<List<int>> reports)
    {
        reports = File.ReadLines(filename)
            .Select(line =>
                line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList())
            .ToList();
    }
}