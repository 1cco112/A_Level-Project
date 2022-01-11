using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazard_Project
{
    public class AdjacencyListRegions
    {
        public LinkedList<Country>[] AdjacencyList;
        public AdjacencyListRegions(int regions)
        {
            AdjacencyList = new LinkedList<Country>[regions];
            for (int count = 0; count < AdjacencyList.Length; count++)
            {
                AdjacencyList[count] = new LinkedList<Country>();
            }
        }
        //functions for adding regions to the lists 
        public void Add_Edge(Country Region1, Country Region2)
        {
            int position = 0;
            AdjacencyList[position].AddLast(Region1);
            position++;
            AdjacencyList[position].AddLast(Region2);
        }
        public void Add_Edge(Country Region1, Country Region2, Country Region3)
        {
            int position = 0;
            AdjacencyList[position].AddLast(Region1);
            position++;
            AdjacencyList[position].AddLast(Region2);
            position++;
            AdjacencyList[position].AddLast(Region3);
        }
        public void Add_Edge(Country Region1, Country Region2, Country Region3, Country Region4)
        {
            int position = 0;
            AdjacencyList[position].AddLast(Region1);
            position++;
            AdjacencyList[position].AddLast(Region2);
            position++;
            AdjacencyList[position].AddLast(Region3);
            position++;
            AdjacencyList[position].AddLast(Region4);
        }
        public void Add_Edge(Country Region1, Country Region2, Country Region3, Country Region4, Country Region5)
        {
            int position = 0;
            AdjacencyList[position].AddLast(Region1);
            position++;
            AdjacencyList[position].AddLast(Region2);
            position++;
            AdjacencyList[position].AddLast(Region3);
            position++;
            AdjacencyList[position].AddLast(Region4);
            position++;
            AdjacencyList[position].AddLast(Region5);
        }
        public void Add_Edge(Country Region1, Country Region2, Country Region3, Country Region4, Country Region5, Country Region6)
        {
            int position = 0;
            AdjacencyList[position].AddLast(Region1);
            position++;
            AdjacencyList[position].AddLast(Region2);
            position++;
            AdjacencyList[position].AddLast(Region3);
            position++;
            AdjacencyList[position].AddLast(Region4);
            position++;
            AdjacencyList[position].AddLast(Region5);
            position++;
            AdjacencyList[position].AddLast(Region6);
        }
        public void Return_Regions(ref string text)
        {
            int count = 0;
            foreach (LinkedList<Country> list in AdjacencyList)
            {
                text += (" Region [" + count + "] :");
                foreach (Country connection in list)
                {
                    text += (connection);
                }
                count++;               
            }
        }
        public void Store_Regions (ref List<Country> list)
        {
            int count = 0;
            list.Clear();
            foreach (LinkedList<Country> list_regions in AdjacencyList)
            {
                foreach (Country connection in list_regions)
                {
                    list.Add(connection);
                }
                count++;
            }
        }
    }
}
