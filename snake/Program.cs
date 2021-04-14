using System;
using System.Collections.Generic;

namespace Snake_OPP_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example from start
            //*that part of code is incapsulation, because we use "point" but didt see how it works
            //put new values
            Point p1 = new Point(1, 3, '*');//we send values to the parametrs in the class point
            p1.Draw();
            // print the dot 
            //second dot
            Point p2 = new Point(5, 4, '#');//we send values to the parametrs in the class point
            p2.Draw();
            // print the dot 
            #endregion

            #region make Horizontal line
            //Here we want to print our horizontal line
            //We need to initialize this object with parametrs
            // to build a line we need x1 from to x2 in the line y with symbol sym 
            HorizontalLine lineH = new HorizontalLine(0,10,0,'W');
            lineH.Draw();
            #endregion

            #region make Vertical line
            //Here we want to print our vertical line
            //We need to initialize this object with parametrs
            // to build a line we need (Start from position)y1 from to (end after reaching position) y2 in the line x with symbol sym 
            VerticalLine lineV = new VerticalLine(0, 10, 0, 'W');
            lineV.Draw();
            #endregion

            #region//commented
            //commented

            //#region List part
            //List<int> numList = new List<int>();

            //// input some nubers into the numList
            //numList.Add(0);
            //numList.Add(1);
            //numList.Add(2);

            ////call the numbers from the list with help of index [n]

            //int x = numList[0];
            //int y = numList[1];
            //int z = numList[2];

            ////to print all list we can use a loop "foreach loop"
            //foreach (int i in numList) // i is parametr for [index] into newList
            //{
            //    Console.WriteLine(i);
            //}

            ////to remove some part of list use this statment:
            //numList.RemoveAt(0); // that function we be remove the number in cell [0] 
            //#endregion list part

            ////on the base list part we will create a list that can be use for dot p1 p2
            //#region Listpoint

            //List<Point> PointList = new List<Point>();



            //#region Point for pointList
            ////new dots for our Point list and there their initialization
            //Point p3 = new Point(9, 16, 'a');//we send values to the parametrs in the class point
            //p3.Draw();
            //Point p4 = new Point(64, 4, 'b');//we send values to the parametrs in the class point
            //p4.Draw();
            //Point p5 = new Point(25, 36, 'c');//we send values to the parametrs in the class point
            //p5.Draw();
            //Point p6 = new Point(49, 1, 'd');//we send values to the parametrs in the class point
            //p6.Draw();
            //Point p7 = new Point(1, 1, 'f');//we send values to the parametrs in the class point
            //p7.Draw();
            //#endregion

            ////PointList
            //PointList.Add(p1);
            //PointList.Add(p2);
            //PointList.Add(p3);
            //PointList.Add(p4);
            //PointList.Add(p5);
            //PointList.Add(p6);
            //PointList.Add(p7);



            ////to print all PointList list we can use a loop "foreach loop"
            //foreach (int i in numList) // i is parametr for [index] into newList
            //{
            //    Console.WriteLine(i);
            //}


            //#endregion Listpoint

            #endregion//commented

            Console.ReadKey();
        }

    }
}
