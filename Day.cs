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
        protected string path = "C:\\AventFile2019";//chemin de base des dossiers
        protected List<string> puzzleinput = new List<string>();//liste de valeurs en string
        protected List<int> puzzleinputINT = new List<int>();//liste de valeurs en entier
        protected string file;//nom du fichier à lire, à définir pour chaque classes

        public string Path { get => path; }

        public virtual void Read_file(string filename)//base de la lecture de fichier, à override !
        {
            puzzleinputINT = new List<int>();
            if (!Directory.Exists(path))
                return;
            path = path + "\\" + filename;
        }

        public virtual int Puzzle1() { return 0; }//base du puzzle 1, à override !
        public virtual int Puzzle2() { return 0; }//base du puzzle 2, à override !

    }
}
