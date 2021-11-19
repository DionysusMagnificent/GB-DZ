using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "NewText.txt";
            File.WriteAllText(filename, Console.ReadLine());
        }

    }
}
