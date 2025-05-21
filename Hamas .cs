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
        public Hamas(string name, string date, string commander)
        {
            _Name = name;
            _DateEstablished = date;
            _Commander = commander;
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


        public void AddMember(Terrorist newterrorist)
        {
            terrorist.Add(newterrorist);
        }
        public void RemoveMember(string name)
        {
            
        }

    }
}
