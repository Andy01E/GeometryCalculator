using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GeometryCalculatorApp
{
    class CubeCalculator : ICalculator
    {
        private double dSide;

        public void CalculateArea()
        {
            double dArea = dSide * dSide * 6;
            Console.Out.WriteLine("The area is " + dArea);
        }

        public void CalculateVolume()
        {
            double dVolume = dSide * dSide * dSide;
            Console.Out.WriteLine("The volume is " + dVolume);
        }

        public void GetMeasurements()
        {
            Console.Out.Write("What is the side of the cube? ");
            String sSide = Console.In.ReadLine();

            dSide = double.Parse(sSide, CultureInfo.InvariantCulture.NumberFormat);
            
        }
    }
}
