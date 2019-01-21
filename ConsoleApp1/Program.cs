using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to test project!");
            Console.WriteLine("Creating new file..Please wait..");
            var now = DateTime.UtcNow;

            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            // Get the current directory.
            string path = Directory.GetCurrentDirectory();
            File.WriteAllLines(path + "\\WriteLines.txt", lines);

            using (var file = new StreamWriter(@path + "\\WriteLines.txt", true))
            {
                file.WriteLine("Fourth line");
                file.WriteLine("Timestamp: " + now);
            }
            Console.WriteLine("done");
        }
    }
}
