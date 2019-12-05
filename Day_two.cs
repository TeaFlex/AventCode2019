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
            Read_file("valuesdaytwo.txt");
        }

        public int Puzzle1()
        {
            puzzleinputINT[1] = 12;
            puzzleinputINT[2] = 2;
            for(int pos=0; pos<puzzleinputINT.Count; pos++)
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
            if (!Directory.Exists(path))
                return;
            string[] tab = File.ReadAllText(path + "\\" + filename).Split(',');
            
            foreach(string word in tab)
            {
                if (Int32.TryParse(word, out int number))
                    puzzleinputINT.Add(number);               
            }
        }
    }
}
