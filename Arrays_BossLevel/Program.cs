using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_BossLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random variable, twodimensional array of a 8x8 matrix
            var random = new Random();
            var roads = new bool[40, 40]; 
            
            GenerateRoad(roads, random.Next(0, 40), random.Next(0, 40), 3);
        }
        static void GenerateRoad(bool[,] roads, int startX, int startY, int direction)
        {
            //Declaring true values to bools depending on direction and starting position:
            switch (direction){
                case 0: //right
                    for (int i = startX ; i < roads.GetLength(0); i++)
                    {                        
                        roads[i, startY] = true; 
                    }
                    break;
                case 1: //down
                    for (int i = startY; i < roads.GetLength(1); i++)
                    {
                        roads[startX, i] = true;
                    }
                    break;
                case 2: //left
                    for (int i = startX; i < roads.GetLength(0); i++)
                    {
                        roads[i, startY] = true;
                    }
                    break;
                case 3: //up
                    for (int i = startY; i < roads.GetLength(1); i++)
                    {
                        roads[startX, i] = true;
                    }
                    break;
            }

            //A nested for loop to draw out the map:
            for (int i = 0; i < roads.GetLength(0); i++)
            {
                for (int j = 0; j < roads.GetLength(1); j++)
                {
                    if (roads[i,j] == true)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

/*
for left and right: 

row remains the same, columm Changes value

for down and up:

column remains the same, row Changes value
*/


/*          var roads = new bool[6, hei];
//8x8 grid
int[,] cityMap = {
{ 1, 2, 3, 4, 5, 6, 7, 8 },
{ 1, 2, 3, 4, 5, 6, 7, 8 },
{ 1, 2, 3, 4, 5, 6, 7, 8 },
{ 1, 2, 3, 4, 5, 6, 7, 8 },
{ 1, 2, 3, 4, 5, 6, 7, 8 },
{ 1, 2, 3, 4, 5, 6, 7, 8 },
{ 1, 2, 3, 4, 5, 6, 7, 8 },
{ 1, 2, 3, 4, 5, 6, 7, 8 }
};

for (int i = 0; i < cityMap.GetLength(0); i++)
{
    for (int j = 0; j < cityMap.GetLength(1); j++)
    {
        Console.Write(cityMap[i, j] + "\t");
    }
    Console.WriteLine();
}
}
}
}
*/



/*
if (roads[2, 3])
{
    Console.WriteLine("Det här är en väg!");
}
else
{
    Console.WriteLine("Här kan du inte gå.");
}
*/