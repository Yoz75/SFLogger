
using System;

namespace SFLogger
{
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Log(message, ConsoleColor.White);
        }

        public static void LogWarning(string message)
        {
            Log($"Warning: {message}", ConsoleColor.DarkYellow);
        }

        public static void LogError(string message)
        {
            Log($"Error: {message}", ConsoleColor.Red);
        }

        public static void LogDebug(string message)
        {
            Log($"Debug: {message}", ConsoleColor.Magenta);
        }

        public static void LogSuccess(string message)
        {
            Log(message, ConsoleColor.Green);
        }

        public static void LogImportant(string message)
        {
            Log(message, ConsoleColor.Black, ConsoleColor.White);
        }

        private static void Log(string message, ConsoleColor foreground)
        {
            var consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = foreground;
            Console.WriteLine(message);
            Console.ForegroundColor = consoleColor;
        }

        private static void Log(string message, ConsoleColor foreground, ConsoleColor background)
        {
            var foregroundColor = Console.ForegroundColor;
            var backgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Write(message);
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine('\n'); //WriteLine(message) can cause wrong formatting, so write new line
            //after color changing
        }
    }
}
