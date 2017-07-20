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

            Console.WriteLine("OhmsLawCalc.");
               Console.WriteLine("Please only enter default values, Ohms NOT MegaOhms.");


            //program will ask for two values. Then if user enters two valid floats, will run math. Spit out missing two values. Then ask if user wants to do it agian.
            //need two of these 4:
            //resistance/ohms (r), current/amps (i), volts (v), watts/power (p)

            //r = v/i resistance = volts / ohms
            //i = v/r 
            //v = i*r volts = amps times ohms
            //to find current in amps, do volts/ohms, watts/volts, sqrt (watts/ohms)
            //starts out in main. Main includes while loop that runs while userContinue is true.
            bool go = true;
            string response = " ";
            while (go == true)
            {

              
                OhmCalc();
                Console.WriteLine("Would you like to run the calc again? Press y or n");
                response = Console.ReadLine();
                
                if (response == "y")
                {
                    go = true;
                }
                else
                {
                    go = false;
                }
            }

        }
        public static void OhmCalc()
        {
           
            float userWatt = 0;
            float userAmp = 0;
            float userVolt = 0;
            float userOhm = 0;

          
            
            //you could instead make a method called doCalc that requires 4 inputs; then runs the code. Pass the float response 
            Console.WriteLine("Ohms?");
            userOhm = float.Parse(Console.ReadLine());
            Console.WriteLine("Volts?");
            userVolt = float.Parse(Console.ReadLine());
            Console.WriteLine("Amps?");
            userAmp = float.Parse(Console.ReadLine());
            Console.WriteLine("Watts?");
            userWatt = float.Parse(Console.ReadLine());
            //so asking user which 2 of the 4 they possess
            

            DoCalc(userOhm, userVolt, userWatt, userAmp);

        
        }
        public static void DoCalc(float inputOhm, float inputVolt, float inputWatt, float inputAmp)
        {
            bool continuing = true;
            float resultOhms = 0;
            float resultVolts = 0;
            float resultAmps = 0;
            float resultWatts = 0;

            int i = 0;
            if (inputOhm > 0)
            {
                i++;
            }
            if (inputVolt > 0)
            {
                i++;
            }
            if (inputWatt > 0)
            {
                i++;
            }
            if (inputAmp > 0)
            {
                i++;
            }
            if (i < 2)
            {
                Console.WriteLine("Please enter at least two of the four values.");
                continuing = false;
            }
            

            while (inputOhm == 0 && inputVolt == 0 && continuing == true)
            {
                resultOhms = inputWatt / (inputAmp * inputAmp);
                resultVolts = inputWatt / inputAmp;

                Console.WriteLine(resultVolts + " Volts.");
                Console.WriteLine(resultOhms + " Ohms.");
                continuing = false;
            }
            while (inputOhm == 0 && inputAmp == 0 && continuing == true)
            {
                resultOhms = (inputVolt * inputVolt) / inputWatt;
                resultAmps = inputWatt / inputVolt;

                Console.WriteLine(resultOhms + " Ohms.");
                Console.WriteLine(resultAmps + " Amps.");
                continuing = false;
            }
            while (inputOhm == 0 && inputWatt == 0 && continuing == true)
            {
                resultOhms = inputVolt / inputAmp;
                resultWatts = inputVolt * inputAmp;

                Console.WriteLine(resultWatts + " Watts.");
                Console.WriteLine(resultOhms + " Ohms.");
                continuing = false;
            }
            while (inputWatt == 0 && inputVolt == 0 && continuing == true)
            {
                resultVolts = inputOhm * inputAmp;
                resultWatts = inputOhm * (inputAmp * inputAmp);

                Console.WriteLine(resultWatts + " Watts.");
                Console.WriteLine(resultVolts + " Volts.");
                continuing = false;
            }
            while (inputWatt == 0 && inputAmp == 0 && continuing == true)
            {
                resultAmps = inputVolt / inputOhm;
                resultWatts = (inputVolt * inputVolt) / inputOhm;

                Console.WriteLine(resultWatts + " Watts.");
                Console.WriteLine(resultAmps + " Amps.");
                continuing = false;
            }
            while (inputVolt == 0 && inputAmp == 0 && continuing == true)
            {
                resultAmps = inputWatt * inputOhm;
                resultVolts = resultAmps * inputOhm;
                Console.WriteLine("Got to here");
                Console.WriteLine(resultAmps + " Amps.");
                Console.WriteLine(resultVolts + " Volts.");
                continuing = false;
            }


        }
    }

}