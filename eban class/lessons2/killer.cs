using System;

namespace lessons2


{
	class Killer : Robot
	{
		public int Health {  get; set; }

		public Killer() { }

		public Killer(string name, int weight, byte[] coordinates, int health): base( name, weight, coordinates)
		{
			this.Health = health;
			base.print();
		}
		public override void print()
		{
			base.print();

            Console.WriteLine("Health" + this.Health);
        }
		public void Lazer()
		{
            Console.WriteLine("lazer shooting");
			this.surname = "Doc";
        }
	}
}
