using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_project_idf
{
    internal class Ahman
    {
        Dictionary<string, Dictionary<string, string>> terrorists = new Dictionary<string, Dictionary<string, string>>();

        public Ahman(string nameTerrorists)
        {
            if (!terrorists.ContainsKey(nameTerrorists)){
                Dictionary<string, string> TerroristDetails = new Dictionary<string, string>();

                Console.Write("הכנס שם: ");
                string name = Console.ReadLine();

                Console.Write(" ");
                string age = Console.ReadLine();

                Console.Write("הכנס תאריך לידה (לדוגמה 01/01/2000): ");

                string birthDate = Console.ReadLine();
                TerroristDetails["שם"] = name;
                TerroristDetails["גיל"] = age;
                TerroristDetails["תאריך לידה"] = birthDate;

            }

         }
    }
}
