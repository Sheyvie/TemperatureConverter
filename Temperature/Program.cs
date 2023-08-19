using System.Threading.Channels;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    //Create a program that converts temperatures between Celsius and Fahrenheit.


    static void Main(string[] args)

    {

        Console.Write("Convert from Celsius or Fahrenheit? (C/F): ");
        char choice = Console.ReadLine()[0];

        string scale = "";

        //Enter temperature in degrees
        Console.WriteLine("Enter Temperature :");

        double temp = Convert.ToDouble(Console.ReadLine());




        double convertTemp = 0;

        if (choice == 'C' || choice == 'c')
        {
            convertTemp = (temp * 9 / 5) + 32;
            scale = "Fahrenheit";
        }
        else if (choice == 'F' || choice == 'f')
        {
            convertTemp = (temp - 32) * 5 / 9;
            scale = "Celsius";
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;

        }



        Console.WriteLine($"{temp} in {scale} is:{convertTemp}");
    }


    }