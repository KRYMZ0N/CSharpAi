using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ai;
using Utils;

namespace mods
{
    public class Module
    {
        Knowledge kn = new Knowledge();
        formatter form = new formatter();
        public Module()
        {

        }
        // Instead of looping these all under main I made a function to keep things clean.
        public void reader()
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s.Equals("hello"))
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

                if (form.checkUp(s))
                {
                    if (kn.mind.Contains("hello"))
                    {
                        Console.WriteLine("I am doing great, and you?");
                    }
                    else
                    {
                        Console.WriteLine("Aren't you going to greet me first?");
                    }

                }

                if (s.Equals("ping"))
                {
                    Console.WriteLine("Pong!");
                }
            }
        }
    }
}
