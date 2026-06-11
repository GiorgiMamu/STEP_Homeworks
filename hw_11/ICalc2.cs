using System;
using System.Collections.Generic;
using System.Text;

namespace hw_11
{
    internal interface ICalc2
    {
        // counts unique values
        int CountDistinct();

        // counts amount of elements that equals to valueToCompare
        int EqualToValue(int valueToCompare);
    }
}
