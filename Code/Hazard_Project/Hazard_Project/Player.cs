using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazard_Project
{
    public class Player
    {
        private int Troops_To_Place = 0;
        private int[] Player_Colour = new int[3];
        private string Player_Name = "";
        public List<string> Occupied_Regions = new List<string>();
        public Player(string name, int r, int g, int b)
        {
            Player_Name = name;
            Player_Colour[0] = r;
            Player_Colour[1] = g;
            Player_Colour[2] = b;
        }
        public string Output_Player_Name()
        {
            return Player_Name;
        }
        public int Output_Colour (int colour_position)
        {
            return Player_Colour[colour_position];
        }
        public void Add_Region(string region)
        {

            Occupied_Regions.Append(region);

        }
        public void Remove_Region(string region)
        {
            int i = 0;
            foreach (string r in Occupied_Regions)
            {
                if (r == region)
                {
                    Occupied_Regions.Remove(r);
                }
                i++;
            }
        }
        public void Set_Troops (int troops)
        {
            Troops_To_Place = troops;
        }
        public void Add_Troops(int troops)
        {
            Troops_To_Place += troops;
        }
        public int Output_Troops ()
        {
            return Troops_To_Place;
        }
    }
    }

