using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Avent_du_code_2019
{
    class Day_one : Day
    {
        private int sum = 0;
        public Day_one()
        {
            file = "dayoneinput.txt";
            Read_file(file);
        }
        public override int Puzzle1()
        {       
            foreach(string mass in puzzleinput)
            {
                if (Int32.TryParse(mass, out int number))
                {
                    number /= 3;
                    number -= 2;
                    sum += number;
                }
                else
                    return 0;
            }
            return sum;
        }

        public override int Puzzle2()
        {
            foreach(string mass in puzzleinput)
            {
                if (Int32.TryParse(mass, out int number))
                {
                    Calculate(number);
                }
                else
                    return 0;
            }
            return sum;
        }

        public void Calculate(int num)
        {
            num /= 3;
            num -= 2;
            if(num > 0)
            {
                sum += num;
                Calculate(num);
            }
        }

        public override void Read_file(string filename)
        {
            base.Read_file(filename);
            if (File.Exists(path))
                puzzleinput = File.ReadAllLines(path).ToList();
        }
    }
}
