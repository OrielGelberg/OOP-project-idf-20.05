using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace OOP_project_idf
{
    internal class Ahman
    {
        Dictionary<string, List<Dictionary<string, string>>> terrorists = new Dictionary<string, List<Dictionary<string, string>>>();
        Hamas hamas = new Hamas();
        List<string> terorost;

        public void ahman(string nameTerrorist, string location)
        {
            DateTime time = DateTime.Now;

            
            Dictionary<string, string> report = new Dictionary<string, string>
            {
                { "location", location },
                { "date", time.ToString("HH:mm dd/MM/yyyy") }
            };

            
            if (!terrorists.ContainsKey(nameTerrorist))
            {
                terrorists[nameTerrorist] = new List<Dictionary<string, string>>();
            }

            terrorists[nameTerrorist].Add(report);

            
        }

        public void add()
        {
            string loc = "home";
            terorost = hamas.getLid();
            foreach (string ter in terorost)
            {
                ahman(ter, loc);
            }
        }

        public string alerts()
        {
            string name = "";
            int max = 0;

            foreach (var kvp in terrorists)
            {
                int reportCount = kvp.Value.Count;
                if (reportCount > max)
                {
                    max = reportCount;
                    name = kvp.Key;
                }
            }

            return $"name: {name}, number: {max}";
        }

        
        
    }
}
