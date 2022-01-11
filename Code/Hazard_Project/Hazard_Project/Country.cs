using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazard_Project
{
    public class Country
    {

        private string Name = "";
        private int Troops = 0;
        private Player Occupier;
        public Country(String name)
        {
            Name = name;
            Troops = 1;
        }
        public void Change_Occupier (Player player)
        {
            Occupier = player;

        }
        public void Add_Troops (int TroopsToAdd)
        {
            Troops += TroopsToAdd;
        }
        public void Remove_Troops(int TroopsToRemove)
        {
            Troops -= TroopsToRemove;
        }
        public int Output_Troops()
        {
            return Troops;
        }
        public Player Output_Player()
        {
            return Occupier;
        }
        public string Output_Name()
        {
            return Name;
        }




    }
    }

