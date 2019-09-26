using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pseudocode
            PROGRAM Assignment Part 4
            HOURLY_RATE = 2.50
            MAX_FEE = 20.00
            INPUT hoursArray txt
            parkingFee = hours * HOURLY_RATE
            IF (parkingFee >MAX_FEE)
            parkingFee = MAX_FEE
            OUTPUT parkingFee
            Average = total + hoursArray
            OUTPUT Average
           */
            const decimal HOURLY_RATE = 2.50m;
            const decimal MAX_FEE = 20.00m;
            decimal parkingFee;
            decimal total = 0;
            double average = 0;
            //input
            int[] hoursArray = new int[30];
            StreamReader fileSR = new StreamReader("hours.txt");
            int counter = 0;
            string line;
            line = fileSR.ReadLine();
            while (line != null)
            {
                hoursArray[counter] = int.Parse(line);
                counter = counter + 1;
                line = fileSR.ReadLine();
            }
            fileSR.Close();
            Console.WriteLine("Hours     Parking Fee");
            //calculation
            for (int index = 0; index < hoursArray.Length; index++)
            {
                parkingFee = hoursArray[index] * HOURLY_RATE;
                if (parkingFee > MAX_FEE)
                {
                    parkingFee = MAX_FEE;
                }
                Console.WriteLine("{0,5} {1,10}",hoursArray[index], parkingFee.ToString("C"));

                total = total + parkingFee;
            }
            average = (double)total / hoursArray.Length;
            //output
            Console.WriteLine("Average parking fee= " + average.ToString("C"));
            Console.ReadKey();
            // Jessica Pratt  9th September
            // Assessment 4    
        }
    }
}
