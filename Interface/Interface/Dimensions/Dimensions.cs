using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimensions
{
    internal interface IDimensions
    {
        float Length();
        float Width();
    }

    class Box : IDimensions
    {
        float lengthInches;
        float widthInches;

        //Constructor
        public Box(float length, float width)
        {
            lengthInches = length;
            widthInches  = width;
        }

        //Explicit interface member implementation:
        float IDimensions.Length()
        {
            return lengthInches;
        }

        //Explicit interface member implementation:
        float IDimensions.Width()
        {
            return widthInches;
        }
    }
}
