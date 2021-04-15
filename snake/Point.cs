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
        /// We gonna build a new constructor. We can use it for task - to build point.
        /// we want make dot with the help other dot
        /// </summary>
        /// <param name="p">dot</param>
        public Point(Point p)
        {
            //it should look like that thing
            //look same like constructor that you can find in the head of class
            x = p.x;
            y = p.y;
            sym = p.sym;

        }

        //Move method

        /// <summary>
        /// Here we gonna put our logic of movement for class snake or point/dot
        /// </summary>
        /// <param name="offset">offset is the num of dots/point that we want to move our snake</param>
        /// <param name="direction">that a parametr that make difference between right and left (right +)(left -) and up and down(up-)(down+)</param>
        public void Move(int offset, Direction direction)
        {

            //right and left movement
            if(direction == Direction.RIGHT)
            {
                x = x + offset;                     //here we want to move right on axis X
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;                     //here we want to move left on axis X
            }
            else if (direction == Direction.UP)
            //up and down movement
            {
                y = y - offset;                     //here we want to move up on axis y
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;                     //here we want to move down on axis y
            }
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

        /// <summary>
        /// some magic from c# to look our dots better on the screen
        /// </summary>
        /// <returns> position info  string</returns>
        public override string ToString()
        {
            return x+ ", "+y+", "+sym;
        }

        /// <summary>
        /// this method is clear a point(what was create before) on the screen
        /// </summary>
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        /// <summary>
        /// that method is working on check of point/dot so we place him in point class
        /// here we check if our snake reached a food and get meaning true/false.
        /// </summary>
        /// <param name="p">point/dot that we want to check (if snake reached a food)</param>
        /// <returns>true-reached a food /false- dont reached a food</returns>
        public bool IsHit(Point p)
        {
            ///that part is checking if parametrs snake's points  is equal to parametrs of food's point 
            return p.x == this.x && p.y == this.y;
        }
    }
}
