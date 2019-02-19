using System;
using System.Collections.Generic;
using System.Text;

namespace UML
{
    class Apollo:SpaceCraft,Drive,Shuttle
    {
        private int gear;

        Apollo(int gear, string model):base()
        {
            this.gear = gear;
            this.model = model;
        }

        public static void Main(string[] args)
        {
            Apollo a = new Apollo(4,"Apollo");
            a.display();
            a.drive();
            a.turn();
            a.stop();
            a.startShuttle();
            a.stopShuttle();

            Console.ReadLine();
        }
        public void drive()
        {
            Console.WriteLine("This space craft can be drive!");
        }

        public void startShuttle()
        {
            Console.WriteLine("\nPress '2' for start this space craft shuttle!");
            int c = int.Parse(Console.ReadLine());

            if (c == 2)
            {
                Console.WriteLine("Shuttle is starting soon.");
            }
            else
            {
                Console.WriteLine("Invalid keyword!");
                startShuttle();
            }
        }

        public void stop()
        {
            Console.WriteLine("\nPress 'o' for stopping this space craft!");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("This space craft is stopping soon.");
            }
            else
            {
                Console.WriteLine("Invalid keyword!");
                stop();
            }
        }

        public void stopShuttle()
        {
            Console.WriteLine("\nPress '3' for stop this space craft shuttle!");
            int d = int.Parse(Console.ReadLine());

            if (d == 3)
            {
                Console.WriteLine("Shuttle is stopping soon.");
            }
            else
            {
                Console.WriteLine("Invalid keyword!");
                stopShuttle();
            }
        }

        public void turn()
        {
            Console.WriteLine("\nPress '1' for turning this space craft!");
            int b = int.Parse(Console.ReadLine());

            if (b == 1)
            {
                Console.WriteLine("This space craft is turning soon.");
            }
            else
            {
                Console.WriteLine("Invalid keyword!");
                turn();
            }
        }
    }
}
