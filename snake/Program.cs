using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake_OPP_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {


            #region new test code

            VerticalLine vl = new VerticalLine(0, 10, 50, '-');
            Draw(vl);
            Point p = new Point(7,7,'7');

            ///now snake is a figure and it have behavior of figure
            ///that's mean if we want use uniqal methods of snake we cant
            Figure Fsnake = new Snake(p, 4, Direction.RIGHT);
            Draw(Fsnake);

            //Fsnake.Move(); // error

            ///for use unique methods of class snake we may insert Fsnake into snake with change type to snake 
            ///now with snake we can use uniq methods of class snake
            Snake snake = (Snake)Fsnake;

            snake.Move();   // worked

            HorizontalLine hl = new HorizontalLine(0, 10, 10, '+');

            List<Figure> figures = new List<Figure>();

            figures.Add(Fsnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }

            #endregion

            #region
            //#region Frame for game
            //// here we start to build our frame for game




            //HorizontalLine upLine = new HorizontalLine(0, 78, 0, 'W');
            //HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, 'W');
            //VerticalLine lineLeftSide = new VerticalLine(0, 24, 0, 'W');
            //VerticalLine lineRightSide = new VerticalLine(0, 24, 78, 'W');

            //upLine.Draw();
            //bottomLine.Draw();
            //lineLeftSide.Draw();
            //lineRightSide.Draw();
            //#endregion

            //#region Snake object
            ////Create object Snake and initialize it with parametrs
            //Point p = new Point(5, 5, 'O');

            //Snake snake = new Snake(p, 2, Direction.RIGHT);

            ////Print object snake
            //snake.Draw();


            /////new realization with the part "food"

            /////*************the call food creator

            /////food creator class 3 parameters
            /////this class is generate a points of food
            //FoodCreator foodCreator = new FoodCreator(80, 25, '$');

            /////create point food on the screen
            /////create a point in the random place on the screen
            //Point food = foodCreator.CreateFood();

            ////print the point food on the screen
            //food.Draw();

            /////we gonna learn our snake to move and eat

            /////while loop is infiniti
            /////here we creater a food
            //while (true)
            //{
            //    if (snake.Eat(food))
            //    {
            //        food = foodCreator.CreateFood();
            //        food.Draw();
            //    }
            //    else
            //    {
            //        snake.Move();
            //    }
            //    Thread.Sleep(100);


            //    ///here checking the key on key board and on the base of meaning key, the snake start move by direction of input
            //    if (Console.KeyAvailable)                       //system function
            //    {
            //        ///this function is work with the meaning of key on the keyboard that was pushed
            //        ConsoleKeyInfo key = Console.ReadKey();     //system function

            //        ///here we call our keyboard control method
            //        snake.HandlingKey(key.Key);
            //    }

            //    ///just a little pause
            //    Thread.Sleep(100);

            //    ///this method is making our snake move foward for num of steps
            //    snake.Move();
            //}

            //#endregion Snake object
            #endregion


        }

        #region new test code
        static void Draw(Figure figure)
        {
            figure.Draw();
        }

        #endregion

}
}
