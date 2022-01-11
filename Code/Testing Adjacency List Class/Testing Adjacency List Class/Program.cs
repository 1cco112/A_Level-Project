using System;

namespace Testing_Adjacency_List_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyListRegions Greenland = new AdjacencyListRegions(4);
            Greenland.Add_Edge("Iceland",0);
            Greenland.Add_Edge("North_West_territory",1);
            Greenland.Return_Regions();
            Console.ReadLine();
        }
    }
}
