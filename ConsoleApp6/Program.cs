using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.add();
            p.remove(int.Parse(Console.ReadLine()));
            //p.search(int.Parse(Console.ReadLine()));
          
          
        }
    }
   public class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lname { get; set; }
        List<person> p;
        public void add()
        {
             p = new List<person>();
            {
               // p.Add(new person { id = int.Parse(Console.ReadLine()), name = Console.ReadLine(), lname = Console.ReadLine() });

                p.Add(new person { id = 1, name = "lllllll", lname = "hghg" });
                p.Add(new person { id = 5, name = "kkkkkkk", lname = "hghg" });
                p.Add(new person { id = 45, name = "mmmmmmmm", lname = "hghg" });

            }
            foreach (var item in p)
            {
             
                {
                    Console.WriteLine(item.name);
                }
            }
            

        }
        public void remove(int id)
        {
            
            p.RemoveAt(id);
            foreach (var item in p)
            {
                Console.WriteLine(item.name);
            }
           
        }
        public void search(int id)
        {
            foreach (var item in p)
            {
                if (id == item.id)
                {
                    Console.WriteLine(item.name);
                }

            }
        }
    }
}
