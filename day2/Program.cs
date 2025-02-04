﻿using day2.Part1;

List<string> part1Input = Part1.ReadInput();
List<int[]> sequencesAsArrays = Part1.SplitSequences(part1Input);
int safeReports = Part1.CountSafeReports(sequencesAsArrays);
Console.WriteLine(safeReports);
