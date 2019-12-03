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
        protected string path = "C:\\AventFile2019";
        protected List<string> puzzleinput = new List<string>();
        protected List<int> puzzleinputINT = new List<int>();

        public string Path { get => path; }

        public virtual void Read_file(string filename)
        {
            if (!Directory.Exists(path))
                return;
            path = path + "\\" + filename;
            puzzleinput = File.ReadAllLines(path).ToList();
        }

    }
}
