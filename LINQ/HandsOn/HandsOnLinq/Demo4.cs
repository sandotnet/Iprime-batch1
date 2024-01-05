using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    //Given a list of participants for a tennis match. Split the list into 2 equal halves and display all the possible
    //combination of matches possible between the participants in the two lists.
    //A condition is that no player should have an opponent who is from his own his own country.
    class Player
    {
        public Player(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get; set; }
        public string Country { get; set;}
    }
    internal class Demo4
    {
        static void Main()
        {
            List<Player> list1 = new List<Player>()
            {
                new Player("Player1","India"),
                new Player("Player2","US"),
            };
            List<Player> list2 = new List<Player>()
            {
                new Player("Player3","India"),
                new Player("Player4","UK"),
            };
            var result = from l1 in list1
                         from l2 in list2
                        where l1.Country != l2.Country
                         select new { op=l1.Name,op1=l2.Name};
            foreach (var p in result)
                Console.WriteLine($"{p.op}*{p.op1}");
        }
    }
}
