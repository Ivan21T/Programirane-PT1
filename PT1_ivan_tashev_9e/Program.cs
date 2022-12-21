using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT1_ivan_tashev_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte eggs = sbyte.Parse(Console.ReadLine());
            sbyte sravnqvane = 0;
            string maxEggsPerColour=null;
            sbyte maxEggs = 0;
            
            
            sbyte blue = 0;
            sbyte red = 0;
            sbyte orange = 0;
            sbyte green = 0;


            while (sravnqvane<eggs) 
            {
                string colour = Console.ReadLine();
                if (colour=="blue")
                {
                    blue += 1;
                    sravnqvane += 1;
                    
                }
                if (colour == "green")
                {
                    green += 1;
                    sravnqvane += 1;
                    
                }
                if (colour == "red")
                {
                    red += 1;
                    sravnqvane += 1;
                }
                if (colour == "orange")
                {
                    orange += 1; 
                    sravnqvane += 1;
                }

            }
            if (green>blue && green>red && green>orange )
            {
                maxEggsPerColour = "green";
                maxEggs = green;
            }
            if (orange > blue && orange > red && orange > green)
            {
                maxEggsPerColour = "orange";
                maxEggs = orange;
            }
            if (blue > green && blue > red && blue > orange)
            {
                maxEggsPerColour = "blue";
                maxEggs = blue;
            }
            if (red > blue && red > green && red > orange)
            {
                maxEggsPerColour = "red";
                maxEggs = red;
            }

            Console.WriteLine("Red eggs:{0}", red);
            Console.WriteLine("Blue eggs:{0}", blue);
            Console.WriteLine("Green eggs:{0}", green);
            Console.WriteLine("Orange eggs:{0}", orange);
            Console.WriteLine("Max eggs:{0} -> {1}", maxEggs,maxEggsPerColour);

        }
    }
}
