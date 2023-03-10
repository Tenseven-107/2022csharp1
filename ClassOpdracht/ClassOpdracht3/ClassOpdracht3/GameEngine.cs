using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOpdracht3
{
    internal class GameEngine
    {
        int loop = 0;

        internal void RunGameLoop()
        {
            while (true)
            {
                loop++;
                Console.WriteLine("loop " + loop.ToString() + " time!");
                System.Threading.Thread.Sleep(1000);//usings komen later dus even met System.Threading ervoor ^^
            }
        }
    }
}
