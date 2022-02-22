using System;

namespace Run_Away
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rabbit Cave!");
            Console.WriteLine("You Will Die, Unless You Outrun the Rabbit!");
            Console.WriteLine("Commands: WASD to Move, Q to Quit.");

                Game g = new Game();
                g.mainLoop();
            
        }
            /* string[,] a = new string[5,5];
             for (int row = 0; row < 5; row++)
             {
                 for (int col = 0; col < 5; col++)
                 {
                     a[col, row] = ".";
                 }
             }
             a[2, 1] = "R";

             for (int row = 0; row < 5; row++)
             {
                 for (int col = 0; col < 5; col++)
                 {
                     Console.Write(a[col,row] + " ");
                 }
                 Console.WriteLine();
             }
             */

            /*int i = 4;
            Point p1 = new Point(2, -1);
            Point p2 = new Point(0, 0);

            Console.WriteLine(i);
            Console.WriteLine(p1.y);
            Console.WriteLine(p2);
            */






            /*Random rgen = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(rgen.Next(100, 105));
            }*/
        
    }
}
