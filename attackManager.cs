using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27;

namespace OOP_project_idf
{
    internal class attackManager
    {
        Hermes460_Zik_Drone hermes460_Zik_Drone = new Hermes460_Zik_Drone();
        F16FighterJet f16FighterJet=new F16FighterJet();
        M109Artillery m109Artillery = new M109Artillery();

        
            
        public void statushermes460_Zik_Drone()
        {
            hermes460_Zik_Drone.Strike();
            f16FighterJet.Strike();
            m109Artillery.Strike();
        }
        public string getFull()
        {

            return$"hermes460_Zik_Drone.Fuel{hermes460_Zik_Drone.Fuel()}  f16FighterJet.Fuel(){f16FighterJet.Fuel()}  m109Artillery.Fuel{m109Artillery.Fuel()}";
        }
    }
}
