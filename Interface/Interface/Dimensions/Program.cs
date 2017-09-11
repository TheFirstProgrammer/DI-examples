using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimensions
{
    class Program
    {
        //A class that implements an interface can explicitly implement a member of that interface. When a member is explicitly implemented, it cannot be accessed through a class instance, but only through an instance of the interface. 
        static void Main(string[] args)
        {
            //Declare a class instance "myBox":
            Box myBox = new Box(30.0f, 20.0f);

            //Declare an interface instance "myDimensions":
            IDimensions myDimensions = (IDimensions)myBox;

            //Print out the dimensions of the box:
            /* The following commented lines would produce compilation 
               errors because they try to access an explicitly implemented
               interface member from a class instance:                   */
            //System.Console.WriteLine("Length: {0}", myBox.Length());
            //System.Console.WriteLine("Width: {0}", myBox.Width());

            /* Print out the dimensions of the box by calling the methods 
                     from an instance of the interface:                         */
            System.Diagnostics.Debug.WriteLine("Length: {0}", myDimensions.Length());
            System.Diagnostics.Debug.WriteLine("Width: {0}", myDimensions.Width());
        }
    }
}
