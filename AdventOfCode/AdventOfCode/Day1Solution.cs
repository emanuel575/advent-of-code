using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdventOfCode
{
    // problem ref: https://adventofcode.com/2023/day/1
    internal class Day1Solution : AdventSolution
    {
        public Day1Solution() { }
        public void RunAdventSolution()
        {
            string filePath = "C:\\Users\\Emanuel\\source\\repos\\advent-of-code\\AdventOfCode\\AdventOfCode\\input_day1.txt";

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        // Read the content of the file line by line
                        int totalSum = 0;
                        while (!reader.EndOfStream)
                        {
                            string? line = reader.ReadLine();
                            if ( line == null)
                            {
                                break;
                            }
                            string digitsOnly = new string(line.Where(char.IsDigit).ToArray());
                            if (digitsOnly.Length == 0)
                            {
                                continue;
                            }

                            else if( digitsOnly.Length == 1 )
                            {
                                var lineNumber = int.Parse($"{digitsOnly[0]}{digitsOnly[0]}");
                                Console.WriteLine($"Line number for length 1 = {lineNumber}");
                                totalSum += lineNumber;
                            }

                            else
                            {
                                var lineNumber = int.Parse($"{digitsOnly[0]}{digitsOnly[digitsOnly.Length-1]}");
                                Console.WriteLine($"Line number for length > 1 = {lineNumber}");
                                totalSum += lineNumber;
                            }
                        }
                        Console.WriteLine($"Day1 Solution is: {totalSum}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
