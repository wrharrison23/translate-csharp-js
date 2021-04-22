using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
      List<Guest> Guests = new List<Guest>(){
                new Guest (){
      name = "Marilyn Monroe",
      occupation = "entertainer",
      bio = "(1926 - 1962) American actress, singer, model"
    },
    new Guest ()
    {
      name = "Abraham Lincoln",
      occupation = "politician",
      bio = "(1809 - 1865) US President during American civil war"
    },
    new Guest ()
    {
      name = "Martin Luther King",
      occupation = "activist",
      bio = "(1929 - 1968)  American civil rights campaigner"
    },
    new Guest ()
    {
      name = "Rosa Parks",
      occupation = "activist",
      bio = "(1913 - 2005)  American civil rights activist"
    },
    new Guest ()
    {
      name = "Peter Sellers",
      occupation = "entertainer",
      bio = "(1925 - 1980) British actor and comedian"
    },
    new Guest ()
    {
      name = "Alan Turing",
      occupation = "computer scientist",
      bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    new Guest ()
    {
      name = "Admiral Grace Hopper",
      occupation = "computer scientist",
      bio = "(1906–1992) - developed early compilers = FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    new Guest ()
    {
      name = "Indira Gandhi",
      occupation = "politician",
      bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
    }
            };

      List<Guest> Table1 = new List<Guest>();
      List<Guest> Table2 = new List<Guest>();

      Dictionary<string, List<Guest>> Tables = new Dictionary<string, List<Guest>>();

      Tables.Add("Table 1", Table1);
      Tables.Add("Table 2", Table2);

      foreach(Guest guest in Guests)
      {
        List<string> table1Occupations = Tables["Table 1"].Select(g => g.occupation).ToList();

        if(table1Occupations.Contains(guest.occupation))
        {
          Tables["Table 2"].Add(guest);
        }
        else {
          Tables["Table 1"].Add(guest);
        }
      }

      foreach(KeyValuePair<string, List<Guest>> tableName in Tables)
      {
        Console.WriteLine(tableName.Key);
        
        foreach (Guest guest in tableName.Value)
        {
          Console.WriteLine($"{guest.name} ({guest.occupation}) {guest.bio})");
        }
      }
    }

       

        
    }

    public class Guest
   {
       public string name { get; set; }
        public string occupation { get; set; }
        public string bio { get; set; }
  }

  
}
