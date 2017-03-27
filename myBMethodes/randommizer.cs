using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBMethodes
{
    public static class randommizer
    {
        private static Random rnd = new Random();

        /// <summary>
        /// Gets the interger.
        /// </summary>
        /// <param name="allowNagative">if set to <c>true</c> [allow nagative].</param>
        /// <returns></returns>
        public static int getInterger(bool allowNagative = true)
        {
            if (allowNagative)
            {
                return rnd.Next(int.MinValue, int.MaxValue);
            }
            else
            {
                return rnd.Next(0, int.MaxValue);
            }

        }
        public static int dobbel()
        {
             return rnd.Next(1,7);
           
        }
        public static string pincode()
        {
            int getal1 = rnd.Next(0, 10);
            int getal2 = rnd.Next(0, 10);
            int getal3 = rnd.Next(0, 10);
            int getal4 = rnd.Next(0, 10);
            string Getal1 = getal1.ToString();
            string Getal2 = getal2.ToString();
            string Getal3 = getal3.ToString();
            string Getal4 = getal4.ToString();
            string totaal = Getal1 + Getal2 + Getal3 + Getal4;

            return totaal;
        }

        public static string names(bool male = true)
        {
            string[] EnglishMaleNames = System.IO.File.ReadAllLines(@"D:\Git Hub\myBMethodes\txt\EnglishMaleNames.txt");
            string[] EnglishFemaleNames = System.IO.File.ReadAllLines(@"D:\Git Hub\myBMethodes\txt\EnglishFemaleNames.txt");
            string[] EnglishSurenames = System.IO.File.ReadAllLines(@"D:\Git Hub\myBMethodes\txt\EnglishSurnames.txt");

            string EnglishMaleName = EnglishMaleNames[rnd.Next(0,EnglishMaleNames.Length +1)];
            string EnglishFemaleName = EnglishFemaleNames[rnd.Next(0, EnglishFemaleNames.Length +1)];
            string EnglishSurename = EnglishSurenames[rnd.Next(0, EnglishSurenames.Length +1)];

            string fullName;
            if (male)
            {
                fullName = EnglishMaleName + " " + EnglishSurename;
            }
            else
            {
                fullName = EnglishFemaleName + " " + EnglishSurename;
            }
            return fullName;
        }
    }
}