using System;

namespace WarriorWars
{
    static class Tools
    {
        public static void ColorFulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}