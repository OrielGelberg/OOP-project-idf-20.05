using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project_idf
{
    internal class Terroristweapon
    {
        private string _WeaponNmae;
        private int _Score;

        Dictionary<string, int> ScoreWeapon = new Dictionary<string, int>()
        {
            {"Knife" , 1},
            {"Gun", 2 },
            {"AK47", 3 },
            {"M16", 3 }

        };
        public int GetScoreByWeaponName(string weaponName)
        {
            if (ScoreWeapon.ContainsKey(weaponName))
                return ScoreWeapon[weaponName];
            else
            {
                Console.WriteLine("There is no such weapon.");
                    return 0;
            }

        }



    }
}
