using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OPP_Csharp
{
    class HorizontalLine
    {

        // here we want to create a list that gona make a borders for our snake
        //lets star from list
        List<Point> horizontalLine;

        //now we need  constructor with initialization


        // consructor with initialization parametrs 

        public HorizontalLine(int xleft, int xright, int y, Char sym)
        {
            // New empty list
            horizontalLine = new List<Point>();

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
                horizontalLine.Add(p);
            }


            #region dots for example commented

            ////lets put some dots for example
            //Point p5 = new Point(2,4, 'c');//we send values to the parametrs in the class point

            //Point p6 = new Point(2, 5, 'd');//we send values to the parametrs in the class point

            //Point p7 = new Point(2, 6, 'f');//we send values to the parametrs in the class point

            //Point p8 = new Point(2, 7, 'c');//we send values to the parametrs in the class point

            //Point p9 = new Point(2, 8, 'd');//we send values to the parametrs in the class point

            //Point p10 = new Point(2, 9, 'f');//we send values to the parametrs in the class point

            //horizontalLine.Add(p5);
            //horizontalLine.Add(p6);
            //horizontalLine.Add(p7);
            //horizontalLine.Add(p8);
            //horizontalLine.Add(p9);
            //horizontalLine.Add(p10);
            #endregion dots for example

        }
        //to print these dots lets build another "Draw" method

        public void Draw()
        {
            //to print all PointList list we can use a loop "foreach loop"


            // we use parametr p  "class Point" for printing our dots on the screen 
            foreach (Point p in horizontalLine) // p is parametr for [index] into newList
            {
                p.Draw(); // we use this method "Draw" from class "Point"
            }
        }

    }
}
