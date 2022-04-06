using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of video game names.       --done
            // Order the list of games by length of the game name.      --done
            // Use the lambda expression and Method Syntax in this exercise as well.    --done

            var videoGames = new List<string>()
            {
                "The Legend of Zelda: Breath of the Wild",
                "World of Warcraft",
                "New World",
                "Path of Exile",
                "Raft",
                "The Last of Us Part II"
            };

            videoGames.OrderBy(name => name.Length)      //takes object and creates a plan to enumerate the object
                .ToList()          //takes the plan (enumberable object) and enumerates it, which creates a concrete object
                .ForEach(name => Console.WriteLine(name));
        }                                                   // you can chain plans together before enumerating them
    }
}
