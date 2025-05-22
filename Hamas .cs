using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project_idf
{
    internal class Hamas : Terrorist_organization
    {
        private string _Name;
        private string _DateEstablished;
        private string _Commander;
        private List<Terrorist> terrorist;
        Random _random = new Random();
        private int numberOfTerrorists;

        public Hamas()
        {
            _Name = "hamas";
            _DateEstablished = "10.12.1984";
            _Commander = "Sinwar";
            numberOfTerrorists = _random.Next(5, 10);
           
            for (int i = 0; i < numberOfTerrorists; i++)
            {
                Terrorist t = new Terrorist(i.ToString());
                terrorist.Add(t);
            }
        }
        public Terrorist getTerrorists(string id)
        {

            int i = 0;
            while (true)
            {
                
                if (i < numberOfTerrorists)
                {
                    if (terrorist[i].get_Id() == id)
                        return terrorist[i];
                    i++;

                }
                else
                    break;
            }
            Console.WriteLine("Dont found this id");
            return null;
        }
            
        

        public List<string> getLid()
        {
            List<string> lID = new List<string>();
            for (int i = 0;i < terrorist.Count; i++)
            {
                lID.Add(terrorist[i].get_Id());

            }
          return lID;
        }
        public string getCommander()
        {
            return _Commander;
        }
        public void setCpmmander(string newCommander)
        {
            _Commander = newCommander;
        }
        public string Name()
        {
            return _Name;
        }
        public string getDateEstablished()
        {
            return _DateEstablished;
        }
        public List<Terrorist> getTerrorist()

        {
           return terrorist;
        }

    


        
        public void KillTerrorist(string nId)
        {
            Terrorist terroristToRemove = null;

            foreach (Terrorist t in terrorist)
            {
                if (t.get_Id() == nId) 
                {
                    terroristToRemove = t;
                    break; 
                }
            }
            if (terroristToRemove != null)
            {
                terrorist.Remove(terroristToRemove);
            }

        }

    }
}
