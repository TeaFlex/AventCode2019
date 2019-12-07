using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Avent_du_code_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            FileControl();
            Console.WriteLine("Day 1 :");
            Console.WriteLine("Puzzle 1: " + new Day_one().Puzzle1());
            Console.WriteLine("Puzzle 2: " + new Day_one().Puzzle2() + "\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Day 2 :");
            Console.WriteLine("Puzzle 1: " + new Day_two().Puzzle1());
            Console.WriteLine("Puzzle 2: " + new Day_two().Puzzle2() + "\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Day 3 :");
            Console.WriteLine("Puzzle 1: " + new Day_three().Puzzle1());
            Console.WriteLine("Puzzle 2: " + new Day_three().Puzzle2() + "\n");
            Console.ReadLine();
            Console.Clear();
        }

        static void FileControl()
        {
            string path = new Day().Path;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            /*for (int i = 1; i <= 31; i++)
            {
                if (!Directory.Exists(path + "\\day" + i))
                    Directory.CreateDirectory(path + "\\day" + i);
            }*/
        }
    }
}
