using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Adjacency_List_Class
{
    class AdjacencyListRegions
    {
        LinkedList<string>[] AdjacencyList;
        public AdjacencyListRegions(int regions)
        {
            AdjacencyList = new LinkedList<string>[regions];
            for (int count = 0; count < AdjacencyList.Length; count++)
            {
                AdjacencyList[count] = new LinkedList<string>();
            }
        }

        public void Add_Edge(string EndRegion, int position)
        {
            AdjacencyList[position].AddLast(new string (EndRegion));
        }

        public int Number_Of_Connected_Regions()
        {
            return AdjacencyList.Length;
        }
        public void Return_Regions()
        {
            int count = 0;

            foreach (LinkedList<string> list in AdjacencyList)
            {
                Console.WriteLine("Region [" + count + "] :");
                foreach (string connection in list)
                {
                    Console.WriteLine(connection);
                }
                count++;
                Console.WriteLine();
            }
        }
    }
}
  
