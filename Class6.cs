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
        DateTime time = DateTime.Now;

        public Ahman(string nameTerrorists)
        {
            
            
            if (!terrorists.ContainsKey(nameTerrorists)){
                Dictionary<string, string> TerroristDetails = new Dictionary<string, string>();

                

                Console.Write("location");
                string age = Console.ReadLine();

                
                
                TerroristDetails["location"] = age;
                TerroristDetails["zman"] = time.ToString("HH:mm dd/MM/yyyy");

                terrorists[nameTerrorists] = TerroristDetails;

                Console.WriteLine("Added successfully");
            }

        }
    }
}
