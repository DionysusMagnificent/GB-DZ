using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Task_Manager
{
    [Serializable]
    class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Program()
        {

        }
        public Program(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
