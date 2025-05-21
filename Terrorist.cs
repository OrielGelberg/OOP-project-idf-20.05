using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project_idf
{
    internal class Terrorist
    {
        private string _Name;
        private int _Rank;
        private bool _live;
        private string _Id;
        private string[] names;
        Random _random = new Random();
        public Terrorist(string id )
        { 

            _Id = id;
            _Rank = _random.Next(1,6);
            _live = true;
            
            names = new string[]{"Ahmed", "Omar", "Ali", "Hassan", "Khaled", "Youssef", "Tariq", "Samir", "Mahmoud", "Nabil"};
            _Name = names[_random.Next(names.Length)];
        }
        public string get_Name() { return _Name; }

        public int get_Rank() { return _Rank; }

        public bool is_live() { return _live; }

        public string get_Id() { return _Id; }
    }
}
