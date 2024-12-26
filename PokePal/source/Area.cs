using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Area
{
    class Areas
    {
        //Dictionary to hold the areas in the game
        public static Dictionary<int, string> areaTracker = new Dictionary<int, string>()
            {
                { 1, "Cove Area" },
                { 2, "Arbor Area" },
                { 3, "Crag Area" },
                { 4, "Tech Area" },
                { 5, "Arcane Area" },
                { 6, "Wish Park" }
            };
        //Method to get the area name based on the number
        public static string getArea(int number)
        {
            if (areaTracker.ContainsKey(number))
            {
                return areaTracker[number];
            }
            else
            {
                return "Area not found!";
            }
        }
    }
}
