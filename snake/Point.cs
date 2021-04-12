using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OPP_Csharp
{
    public class Point
    {
        //this part of code make a dot in the place that the want to put it

        public int x;
        public int y;
        public char sym;
        //end part code

        
        /// <summary>
        /// constructor empty by default should use it....
        /// </summary>
        public Point()
        {
        }

        /// <summary>
        /// New constructor isnt empty here we have working part (initialization)
        /// </summary>
        /// <param name="_x">input</param>
        /// <param name="_y">input</param>
        /// <param name="_sym">input</param>
       
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        /// <summary>
        /// Function for print a dot in the position that we will put through
        /// this function use values that is dirived to parametrs in our class from outside
        /// here we use parametrs from this class
        /// </summary>
        /// <param name="x">x position on window(integer)</param>
        /// <param name="y">y position on window(integer)</param>
        /// <param name="sym">The symbol that we gonna mark our dot(char)</param>
        public void Draw()
        {
            //this part of code make a dot in the place that the want to put it

            Console.SetCursorPosition(x, y); // position
            Console.Write(sym);
            //end part code
        }
    }
}
