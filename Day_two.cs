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

        public string Puzzle1()
        {
            int pos = 0;
            puzzleinputINT[1] = 12;
            puzzleinputINT[2] = 2;
            List<int> resultlist = new List<int>();
            for (int i = 0; i <= puzzleinputINT.Count - 1; i++)
                resultlist.Add(0);
            foreach(int num in puzzleinputINT)
            {
                switch (num)
                {
                    case 1:
                        resultlist[puzzleinputINT[pos + 3]] = puzzleinputINT[puzzleinputINT[pos + 1]] + puzzleinputINT[puzzleinputINT[pos + 2]];
                        break;
                    case 2:
                        resultlist[puzzleinputINT[pos + 3]] = puzzleinputINT[puzzleinputINT[pos + 1]] * puzzleinputINT[puzzleinputINT[pos + 2]];
                        break;
                    case 99:
                        string result = "";
                        foreach(int n in resultlist)
                        {
                            result += n +",";
                        }
                        return result;
                    default:
                        break;
                } 
                pos++;
            }
            return "empty";
        }

        public override void Read_file(string filename)
        {
            if (!Directory.Exists(path))
                return;
            path = path + "\\" + filename;
            string text = File.ReadAllText(path);
            string word = "";
            foreach(char carac in text)
            {
                if(carac == ',')
                {
                    if (Int32.TryParse(word, out int number))
                    {
                        puzzleinputINT.Add(number);
                    }
                    word = "";
                }
                else
                    word += carac;
            }
        }
    }
}
