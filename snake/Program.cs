using System;

namespace Snake_OPP_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////*that part of code is incapsulation, because we use "point" but didt see how it works
            ////put new values
            //Point p1 = new Point(1,3,'*');//we send values to the parametrs in the class point
            //p1.Draw(); 
            //// print the dot 
            ////second dot
            //Point p2 = new Point(5, 4, '#');//we send values to the parametrs in the class point
            //p2.Draw();
            //// print the dot 

            /*Lesson5 RAM*/
            int x = 1;
            x = 1;
            Func1(x);
            Console.WriteLine("call Func1. x = " + x);
            x = 1;
            Func2(x);
            Console.WriteLine("call Func2. x = "+x);

            x = 1;
            Func3(x);
            Console.WriteLine("call Func3. x = " + x);

            Point p1 = new Point(1, 3, '*');
            //here p is address to some place in the ram
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2r = new Point(4, 5, '*');
            Reset(p2r);



            Point p2 = new Point(4, 5, '*');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine(" p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + " ; p2.x = "+p2.x+" , p2.y = " + p2.y);

            p1 = new Point(1,3,'*');
            Update(p1);
            Console.WriteLine("Call Move. p1.x = "+p1.x+ ", p1.y = " +p1.y);


            Console.ReadKey();
        }
        /// <summary>
        /// another function
        /// </summary>
        /// <param name="value">value is a copy of parametr x but it is antother parametr (value and x is not same object)</param>
        public static void Func1(int value)
        {

        }
        /// <summary>
        /// another function
        /// </summary>
        /// <param name="value">value is a copy of parametr x but it is antother parametr (value and x is not same object)</param>
        public static void Func2(int value)
        {
            value = value + 1; // is value changed but not at x. parametr x stay same. * another stack
        }
        /// <summary>
        /// another function
        /// </summary>
        /// <param name="x">THIS "x" is a copy of parametr x but it is antother parametr (this x and x from program is not same object)  * another stack</param>
        public static void Func3(int x)
        {
            x = x + 1;
        }
        /// <summary>
        /// here p is address to some place in the ram
        /// </summary>
        /// <param name="p"> its not the same p1 that just copy in another part of ram</param>
        /// <param name="dx">move by x</param>
        /// <param name="dy">move by y</param>
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
        /// <summary>
        /// this function make reset position of point p 
        /// </summary>
        /// <param name="p">Addres to the position that do you want to set for Point p</param>
        public static void Reset(Point p)
        {
            p = new Point(); // here function is write new addres of "pointer" to p
        }
            

        public static void Update(Point p)
        {

        }

    }
}
