using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace lessons2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot ", 800, new byte[] { 0, 0, 0 });
            bot.print();

            Killer killer = new Killer("Killer ", 1000, new byte[] { 1, 5, 7 }, 100);
            //killer.print();
            killer.Lazer();

            Robot bot1 = new Robot("Bot ");

            //Robot.count = 5;
            Robot.Prin();
            bot1.Width = -100;
            Console.WriteLine(bot1.Width);

            List<Killer> robots = new List<Killer>();
            robots.Add(new Killer("Alex", 400, new byte[] { 0, 0, 10 }, 100));
            robots.Add(new Killer("Bob", 600, new byte[] { 0, 0, 10 }, 100));
            robots.Add(new Killer("Jhon", 500, new byte[] { 0, 0, 10 }, 100));
            robots.Add(new Killer("Josh", 300, new byte[] { 0, 0, 10 }, 100));

            Robot newRobot = null;
            foreach (Killer obj in robots)
            {
                if(obj.Name == "Josh")
                {
                    newRobot = obj as Robot;
                }
                Console.WriteLine(obj is Robot);
            }
            {
                
            }
            Console.ReadLine();
        }
    }
}
