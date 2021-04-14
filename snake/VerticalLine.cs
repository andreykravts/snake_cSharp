using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OPP_Csharp
{
    class VerticalLine
    {
        // here we want to create a list that gona make a borders for our snake
        //lets star from list
        List<Point> verticalLine;

        //now we need  constructor with initialization


        // consructor with initialization parametrs 

        public VerticalLine(int y_up, int y_down ,int x, Char sym)
        {
            // New empty list
            verticalLine = new List<Point>();

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
                verticalLine.Add(p);
            }


        }
        //to print these dots lets build another "Draw" method

        public void Draw()
        {
            //to print all PointList list we can use a loop "foreach loop"


            // we use parametr p  "class Point" for printing our dots on the screen 
            foreach (Point p in verticalLine) // p is parametr for [index] into newList
            {
                p.Draw(); // we use this method "Draw" from class "Point"
            }
        }
    }
}
