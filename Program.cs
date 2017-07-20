using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the values of what you know. If you do not know the value enter zero");

            //program will ask for two values. Then if user enters two valid floats, will run math. Spit out missing two values. Then ask if user wants to do it agian.
            //need two of these 4:
            //resistance/ohms (r), current/amps (i), volts (v), watts/power (p)

            //r = v/i resistance = volts / ohms
            //i = v/r 
            //v = i*r volts = amps times ohms
            //to find current in amps, do volts/ohms, watts/volts, sqrt (watts/ohms)
            //starts out in main. Main includes while loop that runs while userContinue is true.
            bool go = true;

            while (go == true)
            {
            
            

            OhmCalc();
                Console.WriteLine("Would you like to run the calc again?");
                go = Console.ReadLine();
            }

        }
        public static void OhmCalc()
        {
        Console.WriteLine("Ohms?");
            float userOhm = float.Parse(Console.ReadLine());
        Console.WriteLine("Volts?");
            float userVolt = float.Parse(Console.ReadLine());
        Console.WriteLine("Amps?");
            float userAmp = float.Parse(Console.ReadLine());
        Console.WriteLine("Watts?");
            float userWatt = float.Parse(Console.ReadLine());
        }
    }

 }

