using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment24
{
    internal class OurClass
    {
        public void MapProperties(Source source, Destination destination)
        {
            PropertyInfo[] sourceproperties = typeof(Source).GetProperties();
            PropertyInfo[] destinationproperties = typeof(Destination).GetProperties();
            foreach (var sourceproperty in sourceproperties)
            {
                foreach (var destinationproperty in destinationproperties)
                {
                    if (sourceproperty.Name == destinationproperty.Name && (sourceproperty.PropertyType == destinationproperty.PropertyType))
                    {
                        destinationproperty.SetValue(destination, sourceproperty.GetValue(source));
                        break;
                    }
                }
            }
        }
    }
}
