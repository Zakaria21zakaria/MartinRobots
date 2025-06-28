using MartinRobots;
using System;
using System.Collections.Generic;

public class Robot
{
    private int x;
    private int y;
    private Direction direction;
    private readonly int maxX;
    private readonly int maxY;
    private bool isLost;
    private readonly HashSet<string> scents;

    public Robot(int x, int y, Direction direction, int maxX, int maxY, HashSet<string> scents)
    {
        this.x = x;
        this.y = y;
        this.direction = direction;
        this.maxX = maxX;
        this.maxY = maxY;
        this.scents = scents;
        this.isLost = false;
    }

    public void ExecuteInstructions(string instructions)
    {
        foreach (char cmd in instructions)
        {
            if (isLost) break;

            switch (cmd)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'F':
                    MoveForward();
                    break;
                default:
                    Console.WriteLine($"Unknown command: {cmd}");
                    break;
            }
        }
    }

    private void TurnLeft()
    {
        direction = (Direction)(((int)direction + 3) % 4);
    }

    private void TurnRight()
    {
        direction = (Direction)(((int)direction + 1) % 4);
    }

    private void MoveForward()
    {
        int newX = x;
        int newY = y;

        switch (direction)
        {
            case Direction.N: newY++; break;
            case Direction.E: newX++; break;
            case Direction.S: newY--; break;
            case Direction.W: newX--; break;
        }

        if (newX > maxX || newY > maxY || newX < 0 || newY < 0)
        {
            string scentKey = $"{x}:{y}:{direction}";
            if (!scents.Contains(scentKey))
            {
                scents.Add(scentKey);
                isLost = true;
            }
        }
        else
        {
            x = newX;
            y = newY;
        }
    }

    public override string ToString()
    {
        return $"{x} {y} {direction}" + (isLost ? " LOST" : "");
    }
}
