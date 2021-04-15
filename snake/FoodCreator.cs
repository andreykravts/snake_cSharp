using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Snake_OPP_Csharp
{
    class FoodCreator
    {
        /// <summary>
        /// filds, parametrs for creating a point of the food in some place
        /// </summary>
        int MapHeight; //this.MapHeight    (object class)
        int MapWidth;  //this.MapWidth     (object class)
        char sym;      //this.sym          (object class)

        /// <summary>
        /// system function for realization a random method that can help creacte a point of the food in randoms places
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Constructor of the class FoodCreator
        /// have a ...
        /// </summary>
        /// <param name="MapHeight">y axis</param>
        /// <param name="MapWidth">x axis</param>
        /// <param name="sym">symbol to set</param>
        public FoodCreator(int MapWidth, int MapHeight, char sym) //arguments
        {
            ///the meaning of parameters we get from outside. When is function is calling.
            this.MapHeight = MapHeight;
            this.MapWidth = MapWidth;
            this.sym = sym;
        }
        /// <summary>
        /// this is realization of creation points/dots of food in random placement on the map
        /// </summary>
        /// <returns>a new food point/dot on our map.</returns>
        public Point CreateFood()
        {
            int x = random.Next(2, MapWidth - 2);
            int y = random.Next(2, MapHeight - 2);
            return new Point(x,y,sym);
        }

    }
}