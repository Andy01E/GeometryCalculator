using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GeometryCalculatorApp
{
    class PyramidCalculator : ICalculator
    {
        private double dSide;
        private double dHeight;

        public void CalculateArea()
        {
            double dSideHeight = Math.Sqrt(dHeight * dHeight + (dSide / 2) * (dSide / 2));
            double dSideArea = dSide * dSideHeight / 2;
            double dBaseArea = dSide * dSide;
            double dArea = dSideArea * 4 + dBaseArea;

            Console.Out.WriteLine("The area is " + dArea);
            //Math.Sqrt(a^2 + b^2)
        }

        public void CalculateVolume()
        {
            double dBaseArea = dSide * dSide;
            double dVolume = dBaseArea * dHeight / 3;

            Console.Out.WriteLine("The volume is " + dVolume);
        }

        public void GetMeasurements()
        {
            //Basarean
            Console.Out.Write("What is the side of the pyramid? ");
            String sSide = Console.In.ReadLine();

            dSide = double.Parse(sSide, CultureInfo.InvariantCulture.NumberFormat);

            //Höjden
            Console.Out.Write("What is the height of the pyramid? ");
            String sHeight = Console.In.ReadLine();

            dHeight = double.Parse(sHeight, CultureInfo.InvariantCulture.NumberFormat);

        }
    }
}
