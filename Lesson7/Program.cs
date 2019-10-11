using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Insert a number you want to calculate with: ");
            int number = int.Parse(Console.ReadLine());
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine(number.ToString() + " x "+i.ToString()+" = "+(i*number).ToString());
            }
            //task1
            Console.WriteLine("Insert a word: ");
            string str = Console.ReadLine();
            int length = 0;
            foreach(char chr in str)
            {
                length++;
            }
            Console.WriteLine("Length of the inserted word is: "+length.ToString());
            //task2
            
            Console.WriteLine("Insert a word: ");
            string word = Console.ReadLine();
            for(int i=0;i<word.Length; i++)
            {
                Console.Write(word[i] + " ");
            }
            //task3
            
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j.ToString());
                }
                Console.WriteLine(" ");
            }
            //task4
            */
            Console.WriteLine("This is a program that converts Fahrenheit to Celcius and Celsius to Fahrenheit.");
            Console.WriteLine("If you want to convert Fahrenheit to Celsius then type Celsius.");
            Console.WriteLine("If you want to convert Celsius to Fahrenheit type Fahrenheit.");
            string temperatureUnit = Console.ReadLine();
            if (temperatureUnit == "Farenheit")
            {
                Console.WriteLine("Write your temperature in Celsius and I'll convert it to Fahrenheit");
                int celsius = int.Parse(Console.ReadLine());
                int fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("Temperature in Fahrenheit is "+fahrenheit.ToString());
            }
            else
            {
                Console.WriteLine("Write your temperature in Fahrenheit and I'll convert it to Celsius");
                int fahrenheit = int.Parse(Console.ReadLine());
                int celsius = (fahrenheit-32) * 5 / 9;
                Console.WriteLine("Temperature in Celsius is " + celsius.ToString());
            }
            //task5
            Console.ReadLine();
        }

    }
}
