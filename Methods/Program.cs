using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static int score;
        static string name;
        static int xp;
        // Method for showing the HUD

        static void ShowHUD()
        {   // Show HUD
            Console.WriteLine("=================");
            Console.WriteLine("name = " + name);
            Console.WriteLine("score = " + score);
            Console.WriteLine("xp = " + xp);
            Console.WriteLine("=================");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Methods");

            // Methods: procedures, functions
            // Declarations(ONLY EXIST IN BRACKET THEY ARE DECLAIRED IN!)
            //int score;
            //string name;
            //int xp;
            
            // init...
            score = 0;
            name = "NELNOR";
            xp = 0;

            //hud
            ShowHUD();

            //Console.WriteLine("score = " + score);
            //Console.WriteLine("name = " + name);
            //Console.WriteLine("xp = " + xp);
            //Console.WriteLine();
            //sim game
            score = score + 10; 
            xp = xp + 50;

            //hud
            //Console.WriteLine("score = " + score);
            //Console.WriteLine("name = " + name);
            //Console.WriteLine("xp = " + xp);
            //Console.WriteLine();
            ShowHUD();
            // wait for keypress
            score = score + 200;
            xp = xp + 50 * 2;
            ShowHUD();

            Console.ReadKey(true);
        }
    }
}
