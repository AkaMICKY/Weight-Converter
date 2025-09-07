using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I Convert Your Weight in Kg(Kilograms) to Lbs(Pounds)\nSo lets Get Started,");
            Console.Write("Whats Your Weight(Kg)? : "); //Collects User Info
            string Weight = Console.ReadLine(); 
            double WEIGHT = double.Parse(Weight); //Coverts User Input(String) to Decimal For Calculation
            double Weight_lbs = WEIGHT * 2.20462; //Multiply Weight(kg) to Weight(lbs) by multiplying by 2.20462
            double Weight_lbs_round = Math.Round(Weight_lbs, 2); //Rounds Weight to 2 Decimal Places
            Console.WriteLine("According to My Calculations You Should Weigh " + Weight_lbs_round + " lbs");


         

        }
    }
}
