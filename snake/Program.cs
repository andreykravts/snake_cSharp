using System;

namespace Snake_OPP_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            //put new values
            p1.x = 1;//we send values to the parametrs in the class point
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();// now we dint put a values into method because we use parametrs from class point
                      // print the dot 





            ////this part of code make a dot in the place that the want to put it
            ////another dot
            Point p2 = new Point();
            //put new values
            p2.x = 5; //we send values to the parametrs in the class point
            p2.y = 4;
            p2.sym = '#';
            p1.Draw(); // now we dint put a values into method because we use parametrs from class point
            // print the dot 
            ////end part code

            Console.ReadKey();
        }



    }
}
