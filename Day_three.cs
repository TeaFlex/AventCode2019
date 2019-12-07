using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Avent_du_code_2019
{
    class Day_three : Day
    {
        private List<string> puzzleinput2 = new List<string>();
        
        public Day_three()
        {
            file = "daythreeinput.txt";
            Read_file(file);
        }

        public override int Puzzle1()
        {
            List<string> wire1 = Mapping(puzzleinput);
            List<string> wire2 = Mapping(puzzleinput2);
            List<string> nodes = wire1.Intersect(wire2).ToList();
            nodes.RemoveAt(0);
            
            List<int> results = new List<int>();
            foreach(string node in nodes)
            {
                string[] d = node.Split(';');
                results.Add(Math.Abs(Int32.Parse(d[0])) + Math.Abs(Int32.Parse(d[1])));
            }
            return results.Min();
        }

        public override int Puzzle2()
        {
            List<string> wire1 = Mapping(puzzleinput);
            List<string> wire2 = Mapping(puzzleinput2);
            string firstnode = wire1.Intersect(wire2).ToList().ElementAt(1);       
            wire1 = wire1.GetRange(0, wire1.IndexOf(firstnode));
            wire2 = wire2.GetRange(0, wire2.IndexOf(firstnode));
            return wire1.Count + wire2.Count;
        }

        public List<string> Mapping(List<string> instructions)
        {
            List<string> coords = new List<string> { "0;0" };
            int x = 0, y = 0;
            foreach(string travel in instructions)
            {
                char direction = travel.ElementAt(0);
                if (Int32.TryParse(travel.Remove(0, 1), out int n))
                {
                    while (n != 0)
                    {
                        if(direction == 'U')
                        {
                            x++;
                            n--;
                            
                        }
                        else if (direction == 'D')
                        {
                            x--;
                            n--;
                            
                        }
                        else if (direction == 'R')
                        {
                            y++;
                            n--;
                            
                        }
                        else if (direction == 'L')
                        {
                            y--;
                            n--;
                            
                        }
                        coords.Add(x + ";" + y);
                    }
                }
            }
            return coords;
        }


        public override void Read_file(string filename)
        {
            base.Read_file(filename);
            string[] text;
            if (File.Exists(path))
                text = File.ReadAllText(path).Split('\n');
            else
                return;
            puzzleinput = text[0].Split(',').ToList();
            puzzleinput2 = text[1].Split(',').ToList();
        }
    }
}
