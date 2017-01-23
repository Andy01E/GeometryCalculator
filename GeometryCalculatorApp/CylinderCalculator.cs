using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GeometryCalculatorApp
{
    class CylinderCalculator : ICalculator
    {
        private double dRadius;
        private double dHeight;

        public void CalculateArea()
        {
            double dLenght = dRadius * 2 * Math.PI;
            double dSideArea = dLenght * dHeight;
            double dCircleArea = dRadius * dRadius * Math.PI;
            double dArea = dCircleArea * 2 + dSideArea;

            Console.Out.WriteLine("The area is " + dArea);
        }

        public void CalculateVolume()
        {
            double dVolume = dRadius * dRadius * Math.PI * dHeight;
            Console.Out.WriteLine("The volume is " + dVolume);
        }

        public void GetMeasurements()
        {
            //Radien
            Console.Out.Write("What is the radius of the cylinder? ");
            String sRadius = Console.In.ReadLine();

            dRadius = double.Parse(sRadius, CultureInfo.InvariantCulture.NumberFormat);

            //Höjden
            Console.Out.Write("What is the height of the cylinder? ");
            String sHeight = Console.In.ReadLine();

            dHeight = double.Parse(sHeight, CultureInfo.InvariantCulture.NumberFormat);
        }
    }
}
