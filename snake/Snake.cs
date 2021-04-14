using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OPP_Csharp
{
    /// <summary>
    /// Here we will use method abstraction for building object snake. that method to part a tasks.
    /// snake is growing, move, eat, changed direction, that a figure on the display, start position, firstlyy direction....
    /// </summary>
    /// firstly snake is a figure so inheritance to figure!
    /// secondary make a constructor what is gonna take all these parametrs(we gonna use enumeration *see class direction)
    class Snake : Figure
    {
        /// <summary>
        /// Constructor. Here we put a realization of object snake
        /// </summary>
        /// <param name="tail">point/dot</param>
        /// <param name="lenght">lenght of our object</param>
        /// <param name="direction">Direction of start position left right up down</param>
        public Snake(Point tail,int lenght, Direction direction)
        {
            //*here we use list so we need to do for this class is copy of list.
            pList = new List<Point>();
            ///what is idea?
            ///for our object "snake" we goona make this lope.
            ///what is doing our loop? : In the cycle we will create dots. these dots is copy of "tail" dot.
            ///That we initialize in the constructor. after this we want to move our dot. 
            ///After we move our dot on "i" iteration/position in direction of "Direction".
            ///And put it dot in our list "pList"
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);              //*create                                           //In the cycle we will create dots
                p.Move(i, direction);                   //*create                                           //after this we want to move our dot.
                pList.Add(p);                           //*make changes in the point class                  //And put it dot in our list "pList"
                                                    //*we gonna recive lenght dots that gonna be added in our list
            }

        }
    }
}
