using System;

namespace FlagBelarus
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of floors:");
            int Floors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of flats on the floor:");
            int FlatsOnTheFloor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of padiks:");
            int Padiks = Convert.ToInt32(Console.ReadLine());

            for (int f = Floors; f > 0; f--)
            {
                Console.WriteLine();
                for (int p = 1; p <= Padiks; p++)
                {
                    var FlatNumber = f * FlatsOnTheFloor + (Floors * (p - 1) * FlatsOnTheFloor) - FlatsOnTheFloor;
                    var Wideline = (Floors - Floors % 3) / 3;
                    var DarkLine = Floors % 3;
                    for (int k = 1; k <= FlatsOnTheFloor; k++)
                    {
                        FlatNumber++;
                        {
                            if (f <= DarkLine)
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            else if (f > DarkLine && f <= DarkLine + Wideline)
                                Console.ForegroundColor = ConsoleColor.White;

                            else if (f > DarkLine + Wideline && f <= DarkLine + Wideline*2)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = ConsoleColor.White;
                        }

                        Console.Write("{0,5}", FlatNumber);


                    }
                    Console.Write("|");
                }
            }
        }
    }
}
