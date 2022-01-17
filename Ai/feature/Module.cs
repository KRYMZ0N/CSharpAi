using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ai;

namespace mods
{
    public class Module
    {
        Knowledge kn = new Knowledge();
        public Module()
        {

        }
        // Instead of looping these all under main I made a function to keep things clean.
        public void reader()
        {
            while (true)
            {
                if (Console.ReadLine().Equals("hello"))
                {
                    if (!kn.mind.Contains("hello"))
                    {
                        Console.WriteLine("hello there!");
                        kn.mind.Add("hello");
                    }
                    else
                    {
                        Console.WriteLine("Lol, you have already said this to me!");
                    }

                }
                else
                {
                    Console.WriteLine("Not sure what you meant here, try typing hello next time!");
                }

            }
        }
    }
}
