using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculatorApp
{
    interface ICalculator
    {
        void GetMeasurements();
        void CalculateArea();
        void CalculateVolume();
    }
}
