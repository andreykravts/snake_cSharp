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
    class HorizontalLine : Figure
    //*we gonna say that virticallina and horizontalline they just form of figure
    //so we gonna delete some parts code (list and print method), because they belong to class figure
    {

        /// <summary>
        /// here we want to create a list that gona make a borders for our snake
        ///lets star from list
        /// </summary>

        //we use list from class figure


        /// <summary>
        /// now we need  constructor with initialization
        /// consructor with initialization parametrs 
        /// </summary>
        /// <param name="xleft">start from </param>
        /// <param name="xright">go to</param>
        /// <param name="y">in the line </param>
        /// <param name="sym">put some symbol</param>
        public HorizontalLine(int xleft, int xright, int y, Char sym)
        {
            // New empty list
            pList = new List<Point>();

            //here we put "for loop" to initialize points in our line

            for (int x = xleft; x <= xright; x++) // x iterator. we start from xleft and going until we reach xright
            {
                //info
                // so this object of class "point" use parametrs from constractor x,y,sym
                // Because we need to input each dot into a list 
                // so parametr x we need not only for iteration, but for move to next dot position too.
                // y for position in line
                //sym for symbol in dot placement
                Point p = new Point(x, y, sym);

                //There we make at initialization list with the p parameter p(x,y,sym) fro priviosly line
                pList.Add(p);
            }




        }
        //to print these dots lets build another "Draw" method
        /// <summary>
        /// special method that print  the color dots of horizontal line on the screen
        /// </summary>

        //* we use print from class figure ---- not today!

        public override void Draw()
        {
            ///these changes we do SPECIAL for method draw in horizontal line
            Console.ForegroundColor = ConsoleColor.Yellow;


            //here we write same code,that useless]

            //foreach(Point p in pList)
            //{
            //    p.Draw();
            //}


            ///usefull use base realization of code in figure class
            base.Draw();

            ///these changes we do SPECIAL for method draw in horizontal line
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
