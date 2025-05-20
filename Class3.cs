using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27;

namespace OOP_project_idf
{
    internal class Hermes460_Zik_Drone : StrikeUni
    {
        private string nameForValidity;
        private int numberOfHits;
        private int fuel;
        private string efficiency;
        private string pylot;
        private string bomb;

        public Hermes460_Zik_Drone()
        {

        }
        public override void Strike()
        {
            Console.WriteLine($"Strike initiated with: {nameForValidity}, Hits: {numberOfHits}, Fuel: {fuel}, Efficiency: {efficiency}");
        }
        public override int NumberOfHits()
        {
            return numberOfHits;
        }

        public override int Fuel()
        {
            return fuel;
        }

        public override string Efficiency()
        {
            return efficiency;
        }

        public override string NameForValidity()
        {
            return nameForValidity;
        }
    }
}
