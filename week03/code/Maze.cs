using System;
using System.Collections.Generic;
/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private Dictionary<(int, int), bool[]> map;
    private (int, int) currentPosition;

    public Maze(Dictionary<(int, int), bool[]> map)
    {
        this.map = map;
        this.currentPosition = (1, 1); // Starting position
    }

    public void MoveLeft()
    {
        int newX = currentPosition.Item1;
        int newY = currentPosition.Item2 - 1;
        if (IsValidMove(newX, newY, 0))
        {
            currentPosition = (newX, newY);
        }
        else
        {
            Console.WriteLine("Error: Cannot move left.");
        }
    }

    public void MoveRight()
    {
        int newX = currentPosition.Item1;
        int newY = currentPosition.Item2 + 1;
        if (IsValidMove(newX, newY, 1))
        {
            currentPosition = (newX, newY);
        }
        else
        {
            Console.WriteLine("Error: Cannot move right.");
        }
    }

    public void MoveUp()
    {
        int newX = currentPosition.Item1 - 1;
        int newY = currentPosition.Item2;
        if (IsValidMove(newX, newY, 2))
        {
            currentPosition = (newX, newY);
        }
        else
        {
            Console.WriteLine("Error: Cannot move up.");
        }
    }

    public void MoveDown()
    {
        int newX = currentPosition.Item1 + 1;
        int newY = currentPosition.Item2;
        if (IsValidMove(newX, newY, 3))
        {
            currentPosition = (newX, newY);
        }
        else
        {
            Console.WriteLine("Error: Cannot move down.");
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Current position: {currentPosition}");
    }

    private bool IsValidMove(int x, int y, int direction)
    {
        if (!map.ContainsKey((x, y))) return false;
        return map[(x, y)][direction];
    }
}