using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConAppAssignment24
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Source source = new Source();
            Console.WriteLine("**** Enter Properties for Source Class ****");
            Console.WriteLine("Enter ID :");
            source.Id= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            source.Name = Console.ReadLine();
            Console.WriteLine("Enter Date of Joining");
            source.Doj = DateTime.Parse(Console.ReadLine());
            Destination destination = new Destination();
            OurClass I= new OurClass();
            I.MapProperties(source, destination);
            Console.WriteLine("**** Mapped Properties in Destination ****");
            Console.WriteLine($"ID         : \t{destination.Id}");
            Console.WriteLine($"Name       : \t{destination.Name}");
            Console.WriteLine($"Doj        : \t{destination.Doj}");
            Console.WriteLine($"Description: \t{destination.Description}");
            Console.ReadKey();
        }
    }
}
