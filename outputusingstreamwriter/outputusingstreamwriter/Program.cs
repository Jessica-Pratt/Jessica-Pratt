using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outputusingstreamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayData = new string[20];
            StreamReader fileSR = new StreamReader("Adams.txt");
            int counter = 0;
            string line;
            line = fileSR.ReadLine();
            while (line != null)
            {
                arrayData[counter] = line;
                counter = counter + 1;
                line = fileSR.ReadLine();
            }
            fileSR.Close();
            Console.WriteLine("Add your name to the array:");
            arrayData[counter] = Console.ReadLine();
            StreamWriter fileSW = new StreamWriter("Adams.txt");
            for (int index = 0; index <= counter; index++)
            {
                fileSW.WriteLine(arrayData[index]);
            }
            fileSW.Close();
            for (int index = 0; index < arrayData.Length; index++)
            {
                Console.WriteLine(arrayData[index]);
            }
            Console.ReadKey();
        }
    }
}
