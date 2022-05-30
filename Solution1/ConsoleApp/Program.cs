using Microsoft.EntityFrameworkCore;
using SamuraiData;
using SamuraiDomain;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    { 
        private static SamuraiContext _context = new SamuraiContext();
        static void Main(string[] args)
        {
            //AddSamuraisByName("TestA", "TestB", "TestC", "TestD", "TestE");
            //GetSamurais();
            //AddVariousTypes();
            Console.WriteLine("We just retrived our Samurzi EfCore is Easy");
            Console.Write("Press any Key.....");
            Console.ReadKey();
            QueryFilters();
            
        }

        private static void QueryFilters()
        {
            var samurais = _context.Samurais.ToList();
            foreach (var name in samurais)
            {
                Console.WriteLine($"Our samurai Name is {name.Name}");
            }
            Console.WriteLine("QueryFilters is fun");
        }

        private static void AddVariousTypes()
        {
            _context.AddRange(new Samurai { Name = "TypesA" }, new Samurai { Name = "TypesB" },
                  new Battle { Name = "Battle of the Gods"}, 
                  new Battle {Name = "Battle for Enlightment" });
            _context.SaveChanges();
        }

        private static void AddSamuraisByName(params string[] names)
        {
            foreach (string name in names)
            {
                _context.Samurais.Add(new Samurai { Name = name });
            }
            _context.SaveChanges();
        }
        private static void GetSamurais()
        {
            var samurais = _context.Samurais.TagWith("ConsoleApp.Program.GetSamurais Method")
                .ToList();
            Console.WriteLine($"Samurai count is {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}


// if we use a sql profiler to look at the Sql genrerated when we run our progrmm
// we will see some simple sql to add data to the database abd retreive samurai
// note the tagwith ,ethod basically Serve as a comment 
// when u observe the genrated sql in a sql profiler
// we will surely see The contexnt of our tagwith method
// as a comment in our sql
// rest assured tag with issafe swl injection cant be passed into 
// the content of our Tagwith 
// Cause the database will surely wrap the content of our 
//tahwith in a comment line

// but in real life scenario instead of using sqlprofiler to look at the Code
// sql generated, we can use LOggiing   to look at the Sql genrated


// we add .Logto Method in the Samurai Context Class cause we are wotking with console
//we go our OnCpnfiguring Method 

// in asp.net lOgiing is built into it 

//  