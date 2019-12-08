using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avent_du_code_2019
{
    class Day_four : Day
    {
        int inputMIN = 359282, inputMAX = 820401;

        public override int Puzzle1()
        {
            int possibilities = inputMAX - inputMIN + 1;
            for(int i = inputMIN; i<=inputMAX; i++)
            {
                bool verif = true;
                if(i.ToString().Count() == i.ToString().Distinct().Count())
                {
                    verif = false;
                }
                for(int pos = 0; pos<i.ToString().Length-1; pos++)
                {
                    if (Int32.Parse(i.ToString().ElementAt(pos).ToString()) > Int32.Parse(i.ToString().ElementAt(pos + 1).ToString()))
                        verif = false;
                }
                if (!verif)
                    possibilities--;
            }
            return possibilities;
        }

        public override int Puzzle2()
        {
            int possibilities = inputMAX - inputMIN + 1;
            for (int i = inputMIN; i <= inputMAX; i++)
            {
                bool verif = true;
                if (i.ToString().Count() == i.ToString().Distinct().Count())  
                    verif = false;
          
                for (int pos = 0; pos < i.ToString().Length - 1; pos++)
                {
                    if (Int32.Parse(i.ToString().ElementAt(pos).ToString()) > Int32.Parse(i.ToString().ElementAt(pos + 1).ToString()))
                        verif = false;
                }

                bool element = true;
                for (int pos = 0; pos < i.ToString().Length - 1; pos++)
                {
                    if (i.ToString().Count(p => p == i.ToString().ElementAt(pos)) == 2)
                        element = false;
                }
                if (!element)
                    verif = false;

                if (!verif)
                    possibilities--;
            }
            return possibilities;
        }
    }
}
