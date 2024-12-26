using System;
using System.Collections.Generic;

namespace Items
{
class ItemTracker
    {
        //Dictionary to hold the items in the game
        public static Dictionary<int, string> items = new Dictionary<int, string>
        {
            { 1, "Durabubbles" },
            { 2, "Rainbow Pearls" },
            { 3, "Whetstones" },
            { 4, "Gleaming Coins" },
            { 5, "Fluffy Blankets" },
            { 6, "Tube Floats" },
            { 7, "Melody Boxes" },
            { 8, "Honey Jars" },
            { 9, "Aroma Candles" },
            { 10, "Noble Crowns" },
            { 11, "Snazzy Ribbons" },
            { 12, "Sweetleaves" },
            { 13, "Dewdrops" },
            { 14, "Spinwheels" },
            { 15, "Groovy Maracas" },
            { 16, "Everflames" },
            { 17, "Chilly Crystals" },
            { 18, "Salty Rocks" },
            { 19, "Permasnow" },
            { 20, "Shades" },
            { 21, "Paddle Fans" },
            { 22, "Rotor Motors" },
            { 23, "Hardhats" },
            { 24, "Roof Tiles" },
            { 25, "Meteorites" },
            { 26, "Hero's Scarves" },
            { 27, "Joy Seeds" },
            { 28, "Spyscopes" },
            { 29, "Bitter Roots" },
            { 30, "Healthy Greens" },
            { 31, "Compasses" },
            { 32, "Megaphones" }
        };

        public static string getItem(int number)
        {
            if (items.ContainsKey(number))
            {
                return items[number];
            }
            else
            {
                return "Item not found!";
            }
        }
    }
}