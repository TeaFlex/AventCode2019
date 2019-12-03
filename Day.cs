using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Avent_du_code_2019
{
    class Day
    {
        protected string path = "C:\\Users\\Nicolas\\Desktop\\AventFile2019";
        protected List<string> puzzleinput = new List<string>();

        public void Read_file(string filename)
        {
            path = path + "//" + filename;
            puzzleinput = File.ReadAllLines(path).ToList();
        }
    }
}
