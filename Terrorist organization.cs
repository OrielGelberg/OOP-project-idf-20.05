using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project_idf
{
    interface Terrorist_organization
    {
         string getCommander();
        string getDateEstablished();
        void setCpmmander(string newCommander);
        List<Terrorist> getTerrorist();
        void KillTerrorist(string name);
    }
}
