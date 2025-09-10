using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Weight_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome To Weight Converter");
            Console.WriteLine("Select An Option");
            Console.WriteLine("1.Kilograms(Kg) ==> Pounds(Lbs)");
            Console.WriteLine("2.Pounds(Lbs) ==> Kilograms(Kg)");
            Console.WriteLine("3.Grams(G) ==> Ounces(Oz)");
            Console.WriteLine("4.Ounces(Oz) ==> Grams(G)");
            Console.Write("--Option: ");
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int CHOICE))
            {
                if (CHOICE == 1)
                {
                    Console.Write("Enter Weight in Kilogram(Kg): ");
                    string Weight_Kg = Console.ReadLine();
                    if (double.TryParse(Weight_Kg, out double WEIGHT_KG))
                    {
                       double A = KgLbs(WEIGHT_KG);
                        Console.WriteLine(WEIGHT_KG + " Kilograms(Kg) is " + A + " Pounds(Lbs)");
                    }
                    
                } else if (CHOICE == 2)
                {
                    Console.Write("Enter Weight in Pounds(Lbs): ");
                    string Weight_lbs = Console.ReadLine();
                    if (double.TryParse(Weight_lbs, out double WEIGHT_LBS))
                    {
                        double A = LbsKg(WEIGHT_LBS);
                        Console.WriteLine(WEIGHT_LBS + " Pounds(Lbs) is " + A + " Kilograms(Kg)");
                    }
                } else if (CHOICE == 3)
                {
                    Console.Write("Enter Weight in Grams(G): ");
                    string Weight_G = Console.ReadLine();
                    if (double.TryParse(Weight_G, out double WEIGHT_G))
                    {
                        double A = GOz(WEIGHT_G);
                        Console.WriteLine(WEIGHT_G + " Grams(G) is " + A + " Ounces(Oz)");
                    }
                } else if (CHOICE == 4)
                {
                    Console.Write("Enter Weight in Ounces(Oz): ");
                    string Weight_Oz = Console.ReadLine();
                    if (double.TryParse(Weight_Oz, out double WEIGHT_OZ))
                    {
                        double A = GOz(WEIGHT_OZ);
                        Console.WriteLine(WEIGHT_OZ + " Ounces(Oz) is " + A + " Grams(G)");
                    }
                } else
                {
                    Console.WriteLine(CHOICE + " is not an Available Option, Select a Valid Option (1,2,3 or 4)");
                }
            } else
            {
                Console.WriteLine(CHOICE + " is not an Option");
            }

            

         

        }

        static double KgLbs (double a)
        {
            double A = a * 2.20462;
            double A_Kg = Math.Round(A, 2);
            return A_Kg;

        }

        static double LbsKg (double b)
        {
            double B = b * 0.453592;
            double B_Lbs = Math.Round(B, 2);
            return B_Lbs;
        }

        static double GOz (double c)
        {
            double C = c * 0.035274;
            double C_G = Math.Round(C, 2);
            return C_G;
        }

        static double OzG (double d)
        {
            double D = d * 28.3495;
            double D_Oz = Math.Round(D, 2);
            return D_Oz;
        }
    }
}
