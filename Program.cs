﻿using System;
class Program
{
    static void Main()
    {
        Console.Title = "Move star with cursor";
        Console.Write("Enter the moving element -> ");
        string movingElement = Console.ReadLine();

        ConsoleKeyInfo keyInfo;
        int cursorLeft = Console.CursorLeft;
        int cursorTop = Console.CursorTop;

        while (true)
        {
            keyInfo = Console.ReadKey(true);

            Console.Clear();
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (cursorLeft > 0)
                    {
                        cursorLeft--;
                    }
                    else
                    {
                        cursorLeft = Console.WindowWidth;
                        cursorLeft--;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (cursorLeft < Console.WindowWidth - 1)
                    {
                        cursorLeft++;
                    }
                    else
                    {
                        cursorLeft = -1;
                        cursorLeft++;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (cursorTop > 0)
                    {
                        cursorTop--;
                    }
                    else
                    {
                        cursorTop = Console.WindowHeight;
                        cursorTop--;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (cursorTop < Console.WindowHeight - 1)
                    {
                        cursorTop++;
                    }
                    else
                    {
                        cursorTop = -1;
                        cursorTop++;
                    }
                    break;

                case ConsoleKey.Escape:
                    return; // Exit the loop and program
            }

            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.Write(movingElement);
        }
    }
}