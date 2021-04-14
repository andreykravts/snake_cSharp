using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake_OPP_Csharp
{
    /// <summary>
    /// that lesson about inheritance this class will be contain all previosly classes with print lines and other stuff
    /// </summary>
    class Figure
    {
        //we put modificator "Protected" because we want that only children class may use the "List"
        protected List<Point> pList;








        /// <summary>
        /// method that print the dots on the screen
        /// </summary>
        public void Draw()
        {
            //to print all PointList list we can use a loop "foreach loop"


            // we use parametr p  "class Point" for printing our dots on the screen 
            foreach (Point p in pList) // p is parametr for [index] into newList
            {
                p.Draw(); // we use this method "Draw" from class "Point"
            }
        }
    }
}
