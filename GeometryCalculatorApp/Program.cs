using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bRun = true;
            do
            {

                Console.Out.WriteLine("Geometry Calculator App");
                Console.Out.WriteLine("1. Area of cylinder \n2. Volume of cylinder \n3. Area of cube \n4. Volume of cube\n5. Area of pyramid \n6. Volume of pyramid \nx to exit");

                String answer = Console.In.ReadLine();

                if (answer == "x")
                {
                    bRun = false;
                }
                else
                {

                    ICalculator calc = null;

                    if (answer == "1" || answer == "2")
                    {
                        calc = new CylinderCalculator();
                    }
                    else if (answer == "3" || answer == "4")
                    {
                        calc = new CubeCalculator();
                    }
                    else if (answer == "5" || answer == "6")
                    {
                        calc = new PyramidCalculator();
                    }

                    if (calc != null)
                    {
                        //GetMeasurement
                        calc.GetMeasurements();

                        Console.Out.Write("Thinking");

                        for(int i = 0; i < 10; i++)
                        {
                            Console.Out.Write(".");
                            for(int j =0; j<100000000; j++)
                            {
                                //do nothing
                            }
                        }
                        Console.Out.WriteLine();

                        //Calculate
                        if (answer == "1" || answer == "3" || answer == "5")
                        {
                            calc.CalculateArea();
                        }
                        else if (answer == "2" || answer == "4" || answer == "6")
                        {
                            calc.CalculateVolume();
                        }
                        Console.Out.WriteLine();
                    }


                }

            } while (bRun);

        }
    }
}
