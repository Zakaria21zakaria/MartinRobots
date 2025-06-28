using MartinRobots;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        string[] gridSize = Console.ReadLine().Trim().Split();
        int maxX = int.Parse(gridSize[0]);
        int maxY = int.Parse(gridSize[1]);

        var scents = new HashSet<string>();

        string? positionLine;

        while (!string.IsNullOrEmpty(positionLine = Console.ReadLine()))
        {
            string[] pos = positionLine.Trim().Split();
            int x = int.Parse(pos[0]);
            int y = int.Parse(pos[1]);

            string dirStr = pos[2].Trim().ToUpper();
            if (!Enum.TryParse(dirStr, out Direction direction))
            {
                Console.WriteLine($"Invalid direction: {dirStr}");
                continue;
            }

            string? instructions = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(instructions))
            {
                Console.WriteLine("Missing instruction line.");
                continue;
            }

            var robot = new Robot(x, y, direction, maxX, maxY, scents);
            robot.ExecuteInstructions(instructions);
            Console.WriteLine(robot);
        }
    }
    
}
