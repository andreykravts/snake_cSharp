using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OPP_Csharp
{
    /// <summary>
    /// we use inheritance here so we get:
    /// class contains all functional of ""Figure" class
    /// </summary>
    class VerticalLine : Figure    
        //*we gonna say that virticallina and horizontalline they just form of figure
        //so we gonna delete some parts code(list and print method), because they belong to class figure
    {
        /// <summary>
        ///         here we want to create a list that gona make a borders for our snake
        ///lets star from list
        /// </summary>
       
        //we use list from class figure
       

        /// <summary>
        /// now we need  constructor with initialization consructor with initialization parametrs 
        /// </summary>
        /// <param name="y_up">start from</param>
        /// <param name="y_down">go down to</param>
        /// <param name="x">in the line</param>
        /// <param name="sym">put the symbol</param>

        public VerticalLine(int y_up, int y_down ,int x, Char sym)
        {
            // New empty list
            pList = new List<Point>();

            //here we put "for loop" to initialize points in our line

            for (int y = y_up; y <= y_down; y++) // y iterator. we start from y_up and going until we reach y_down
            {
                //info
                // so this object of class "point" use parametrs from constractor (x, y, sym)
                // Because we need to input each dot into a list 
                // so parametr y we need not only for iteration, but for move to next dot position too.
                // x for position in line
                //sym for symbol in dot placement
                Point p = new Point(x, y, sym);

                //There we make at initialization list with the p parameter p(x,y,sym) fro priviosly line
                pList.Add(p);
            }


        }
        //to print these dots lets build another "Draw" method

        // we use print from class figure
       
    }
}
