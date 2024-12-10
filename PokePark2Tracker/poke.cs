using System;
using System.Collections.Generic;

class PokemonTracker{ 
    private static Dictionary<int, string> Pokedex = new Dictionary<int, string>()
            {
                {1, "Piplup"},
                {2, "Timburr"},
                {3, "Patrat"},
                {4, "Watchog"},
                {5, "Sandile"},
                {6, "Krokorok"},
                {7, "Krookodile"},
                {8, "Wingull"},
                {9, "Pelipper"},
                {10, "Driblim"},
                {11, "Minccino"},
                {12, "Cinccino"},
                {13, "Pansage"},
                {14, "Pansear"},
                {15, "Panpour"},
                {16, "Espeon"},
                {17, "Munchlax"},
                {18, "Samurott"},
                {19, "Axew"},
                {20, "Fraxure"},
                {21, "Pidove"},
                {22, "Tranquill"},
                {23, "Maractus"},
                {24, "Alomomola"},
                {25, "Frillish"},
                {26, "Drilbur"},
                {27, "Petilil"},
                {28, "Meowth"},
                {29, "Misdreavus"},
                {30, "Musharna"},
                {31, "Blitzle"},
                {32, "Audino"},
                {33, "Raichu"},
                {34, "Servine"},
                {35, "Pignite"},
                {36, "Dewott"},
                {37, "Purrloin"},
                {38, "Trubbish"},
                {39, "Corphish"},
                {40, "Emolga"},
                {41, "Staryu"},
                {42, "Wailord"},
                {43, "Tornadus"},
                {44, "Kecleon"},
                {45, "Karrablast"},
                {46, "Cottonee"},
                {47, "Whimsicott"},
                {48, "Caterpie"},
                {49, "Scyther"},
                {50, "Sudowoodo"},
                {51, "Zorua"},
                {52, "Zoroark"},
                {53, "Pawniard"},
                {54, "Bisharp"},
                {55, "Buneary"},
                {56, "Leafeon"},
                {57, "Foongus"},
                {58, "Amoonguss"},
                {59, "Tympole"},
                {60, "Seismitoad"},
                {61, "Magikarp"},
                {62, "Oddish"},
                {63, "Mankey"},
                {64, "Kakuna"},
                {65, "Snorlax"},
                {66, "Sewaddle"},
                {67, "Leavanny"},
                {68, "Lilligant"},
                {69, "Serperior"},
                {70, "Deerling"},
                {71, "Vaporeon"},
                {72, "Psyduck"},
                {73, "Shroomish"},
                {74, "Venipede"},
                {75, "Whirlipede"},
                {76, "Scolipede"},
                {77, "Skiploom"},
                {78, "Surskit"},
                {79, "Basculin"},
                {80, "Dugtrio"},
                {81, "Ducklett"},
                {82, "Stunfisk"},
                {83, "Excadrill"},
                {84, "Woobat"},
                {85, "Ferrothorn"},
                {86, "Bronzong"},
                {87, "Burmy"},
                {88, "Victini"},
                {89, "Bastiodon"},
                {90, "Darumaka"},
                {91, "Darmanitan"},
                {92, "Scraggy"},
                {93, "Bonsly"},
                {94, "Bellossom"},
                {95, "Metapod"},
                {96, "Croagunk"},
                {97, "Dwebble"},
                {98, "Crustle"},
                {99, "Primeape"},
                {100, "Ferroseed"},
                {101, "Gible"},
                {102, "Garchomp"},
                {103, "Druddigon"},
                {104, "Emboar"},
                {105, "Diglett"},
                {106, "Flareon"},
                {107, "Braviary"},
                {108, "Mandibuzz"},
                {109, "Cubchoo"},
                {110, "Beartic"},
                {111, "Munna"},
                {112, "Throh"},
                {113, "Sawk"},
                {114, "Delibird"},
                {115, "Boldore"},
                {116, "Vanillite"},
                {117, "Geodude"},
                {118, "Rhyperior"},
                {119, "Swoobat"},
                {120, "Glaceon"},
                {121, "Hydreigon"},
                {122, "Aipom"},
                {123, "Breloom"},
                {124, "Lucario"},
                {125, "Thundurus"},
                {126, "Gurdurr"},
                {127, "Conkeldurr"},
                {128, "Golett"},
                {129, "Golurk"},
                {130, "Zebstrika"},
                {131, "Accelgor"},
                {132, "Tyranitar"},
                {133, "Salamence"},
                {134, "Murkrow"},
                {135, "Honchkrow"},
                {136, "Abra"},
                {137, "Scizor"},
                {138, "Escavalier"},
                {139, "Roggenrola"},
                {140, "Gigalith"},
                {141, "Mawile"},
                {142, "Voltorb"},
                {143, "Wynaut"},
                {144, "Kirlia"},
                {145, "Lopunny"},
                {146, "Eevee"},
                {147, "Solosis"},
                {148, "Duosion"},
                {149, "Reuniclus"},
                {150, "Sableye"},
                {151, "Stunky"},
                {152, "Joltik"},
                {153, "Galvantula"},
                {154, "Electivire"},
                {155, "Garbodor"},
                {156, "Magmortar"},
                {157, "Umbreon"},
                {158, "Sneasel"},
                {159, "Gengar"},
                {160, "Duskull"},
                {161, "Dusknoir"},
                {162, "Klink"},
                {163, "Klang"},
                {164, "Klinklang"},
                {165, "Mareep"},
                {166, "Lotad"},
                {167, "Hoppip"},
                {168, "Swadloon"},
                {169, "Jolteon"},
                {170, "Charizard"},
                {171, "Slowpoke"},
                {172, "Squirtle"},
                {173, "Mudkip"},
                {174, "Azurill"},
                {175, "Budew"},
                {176, "Krabby"},
                {177, "Sawsbuck"},
                {178, "Bouffalant"},
                {179, "Scrafty"},
                {180, "Swanna"},
                {181, "Landorus"},
                {182, "Gothita"},
                {183, "Gothorita"},
                {184, "Gothitelle"},
                {185, "Yamask"},
                {186, "Cofagrigus"},
                {187, "Litwick"},
                {188, "Lampent"},
                {189, "Chandelure"},
                {190, "Haxorus"},
                {191, "Sigilyph"},
                {192, "Darkrai"},
                {193, "Reshiram"},
                {194, "Zekrom"}
            };
    public static string GetPokemon(int number)
    {
        if (Pokedex.ContainsKey(number))
        {
            return Pokedex[number];
        }
        else
        {
            return "Pokemon not found!";
        }
    }
}
class Program{
    public static void Main()
    {
        //TODO figure out whatever this is
        }
}