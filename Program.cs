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
        static void MapProperties(Source source, Destination destination)
        {
            PropertyInfo[] sourceproperties = typeof(Source).GetProperties();
            PropertyInfo[] destinationproperties = typeof(Destination).GetProperties();
            foreach (var sourceproperty in sourceproperties)
            {
                foreach (var destinationproperty in destinationproperties)
                {
                    if (sourceproperty.Name== destinationproperty.Name && (sourceproperty.PropertyType == destinationproperty.PropertyType))
                    {
                        destinationproperty.SetValue(destination, sourceproperty.GetValue(source));
                        break;
                    }
                }
            }
        }
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
            MapProperties(source, destination);
            Console.WriteLine("**** Mapped Properties in Destination ****");
            Console.WriteLine($"ID         : \t{destination.Id}");
            Console.WriteLine($"Name       : \t{destination.Name}");
            Console.WriteLine($"Doj        : \t{destination.Doj}");
            Console.WriteLine($"Description: \t{destination.Description}");
            Console.ReadKey();
        }
    }
}
