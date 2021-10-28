using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace EmailSendGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetAllItems();
            Console.WriteLine(JsonSerializer.Serialize(x));
        }

        public static IEnumerable<Items> CreateDumpItems()
        {
            List<Items> items = new List<Items>()
            {
                new Items()
                {
                Id = 101,
                Name = "Milk",
                Price = 500
                },
                new Items()
                {
                Id = 102,
                Name = "Apple",
                Price = 250
                },
                new Items()
                {
                Id = 103,
                Name = "Banana",
                Price = 150
                },
                new Items()
                {
                Id = 104,
                Name = "Cat",
                Price = 2500
                }
            };

            return items;
        }

        public static IEnumerable<Items> GetAllItems()
        {
            var items = CreateDumpItems();
            
            int spyCalcCount = 0;
            foreach (var i in items)
            {
                ++spyCalcCount;
                if (i.Id == 102)
                {
                    Console.WriteLine(spyCalcCount);
                    yield return i;                    
                }
            }
        }

        public class Items
        {
            public int Id {get;set;}
            public string Name {get; set;}
            public double Price {get;set;}
        }
    }
}
