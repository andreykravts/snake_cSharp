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
        /// this thing we need to remember which direction going a head
        /// now class snake holding the data. Direction data. Data of which direction should move a snake.
        /// </summary>
        Direction direction;

        /// <summary>
        /// Constructor. Here we put a realization of object snake
        /// </summary>
        /// <param name="tail">point/dot</param>
        /// <param name="lenght">lenght of our object</param>
        /// <param name="direction">Direction of start position left right up down</param>
        public Snake(Point tail,int lenght, Direction _direction)
        {

            ///inside our method we need to diliver direction from outside
            direction = _direction;



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
        /// <summary>
        /// That method is say that snake need to move forward. what is mean a head do step(get/add new point) and a tail delete 1 point.
        /// these operations will see like moving.
        /// </summary>
        internal void Move()
        {
            ///here we took a tail from list
            ///method first is giving a first element of our list
            Point tail = pList.First();
            /// the moving of snake straight forward so this point in the tail point that you can call last must disapear
            pList.Remove(tail);
            ///Our head need to be moved some direction so because of that
            ///we call GetNextPoint method to add new point in head or you may call 
            ///it make a step in some direction
            ///parametr head will get some meaning that we get from method getnextpoint 
            Point head = GetNextPoint();
            ///Put new meaning of head into the list
            pList.Add(head);
            ///this method using for "Tail Point"
            ///clear tail point from the screen 
            ///with the help of this method we can see iliusion of the moving all snake to some point
            tail.Clear();
            /// print is new point of head on the screen
            head.Draw();
        }

        /// <summary>
        /// now is snake class giving to us method that have a functional of control movening our snake 
        /// </summary>
        /// <param name="key">this thing is check that key(arrow) on keyboard you puch and change direction of snake </param>
        public void HandlingKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        ///the result of work next method is some object of class point
        public Point GetNextPoint()
        {
            ///a current position of the snake before moving
            /// Last is the method of list function
            Point head = pList.Last();
            ///After we put new dot that is a copy of previosly positin of the head
            Point nextPoint = new Point(head);
            ///method move is the method of class point that giving direction of move
            ///moving the dot
            nextPoint.Move(1, direction); 
            ///this method is giving a back new dot/point to head after the moving process
            return nextPoint;
        }
    }
}
