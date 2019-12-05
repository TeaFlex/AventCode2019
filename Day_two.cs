using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Avent_du_code_2019
{
    class Day_two : Day
    {
        public Day_two()
        {
            path += "\\day2";
            file = "valuesdaytwo.txt";
            Read_file(file);
        }

        public override int Puzzle1()
        {
            return Intcomputer(12, 2);
        }

        public override int Puzzle2()
        {
            for(int noun = 0; noun <= 99 ; noun++)
            {
                for(int verb = 0; verb <= 99; verb++)
                {
                    if (Intcomputer(noun, verb) == 19690720)
                        return noun * 100 + verb;
                    else
                        Read_file(file);
                }
            }
            return -1;
        }
        public int Intcomputer(int noun, int verb)
        {
            puzzleinputINT[1] = noun;
            puzzleinputINT[2] = verb;
            for (int pos = 0; pos < puzzleinputINT.Count; pos += 4)
            {
                switch (puzzleinputINT[pos])
                {
                    case 1:
                        puzzleinputINT[puzzleinputINT[pos + 3]] = puzzleinputINT[puzzleinputINT[pos + 1]] + puzzleinputINT[puzzleinputINT[pos + 2]];
                        break;
                    case 2:
                        puzzleinputINT[puzzleinputINT[pos + 3]] = puzzleinputINT[puzzleinputINT[pos + 1]] * puzzleinputINT[puzzleinputINT[pos + 2]];
                        break;
                    case 99:
                        return puzzleinputINT[0];
                    default:
                        break;
                }
            }
            return -1;
        }

        public override void Read_file(string filename)
        {
            base.Read_file(filename);
            string[] tab = File.ReadAllText(path).Split(',');
            
            foreach(string word in tab)
            {
                if (Int32.TryParse(word, out int number))
                    puzzleinputINT.Add(number);               
            }
        }
    }
}
