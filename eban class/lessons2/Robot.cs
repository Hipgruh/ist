using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lessons2
{
    internal class Robot
    {
        public static int count;

        private string name;
        private int weight;
        private byte[] coordinates;
        protected string surname;
        public string Name { get { return name; } private set { } }

        public int Weight
        {
            get {
                Console.WriteLine("res: ");
                return this.weight; 
            }
            set { if (value < 1)
                    this.weight = 1;
                else if (value > 5000)
                    this.weight = 5000;
                else
                    this.weight = value;
            }
        }

        public int Width { get; set; }

        public Robot(string name, int weight, byte[] coordinates) 
        { 
            Console.WriteLine("created"); 
            Value(name, weight, coordinates);
            count++;
        }
        public Robot(string name)
        {
            Console.WriteLine("created");
            this.name = name;
            count++;
        }
        public Robot() {
            Console.WriteLine("created");
            count++;
        }

        public void Value(string name, int weight, byte[] coordinates)
        {
           this.name = name;
           this.weight = weight;
           this.coordinates = coordinates;

        }
        public virtual void print()
        {
          Console.WriteLine(this.name + "weight " + this.weight + ".coordinates: ");
            foreach (byte el in coordinates)
            {
                Console.WriteLine(el);
            }
        }

        public static void Prin()
        {
            Console.WriteLine("count is " + count);
        }
    }
}
