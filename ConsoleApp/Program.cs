using ConsoleApp.Models;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //###################### USANDO O CARRO #####################
            //                          _______
            //                         //  ||\ \
            //                   _____//___||_\ \___
            //                   )  _          _    \
            //                   |_/ \________/ \___|
            //                  ___\_/________\_/______
            //Car fusca; // =)
            //fusca = new Car();

            ////Ana vai pilotar seu fusca!
            //Console.WriteLine("Direção do Volante:");
            //Console.WriteLine(fusca.CurrentDirection);
            //Console.WriteLine();

            //fusca.TurnLeft(90);
            //fusca.SpeedUp(70);
            //Console.WriteLine("Velocidade: " + fusca.CurrentSpeed + "km/h");
            //fusca.SpeedDown(10);
            //Console.WriteLine("Velocidade: " + fusca.CurrentSpeed + "km/h");
            //fusca.TurnRight(180);
            //fusca.SpeedDown(60);
            //Console.WriteLine("Velocidade: " + fusca.CurrentSpeed + "km/h");
            //##############################################################




            //#################### USANDO O AVIÃO ###################
            AirPlane boeing747;
            boeing747 = new AirPlane();

            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);

            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(200);
            boeing747.GoUp(200);

            for(int i=0; i<9; i++)
            {
                boeing747.GoDown(100);
                Console.WriteLine("Altura: " + boeing747.CurrentHeight + "m");
            }
            //#######################################################


        }
    }
}
