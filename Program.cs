using System;
using csharp_intro.Models;

namespace csharp_intro
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Target Joker = new Target("The Joker", 100);
      Target Bane = new Target("Bane", 125);
      Console.WriteLine("Hello Batman... Whoe would you like to Fight?");
      Console.WriteLine(Joker.Name);
      Console.WriteLine(Bane.Name);
      var choice = Console.ReadLine();
      Target currentTarget = Joker;
      if (choice == Joker.Name)
      {
          currentTarget = Joker;
      }
			if (choice == Bane.Name)
      {
          currentTarget = Bane;
      }

			while(currentTarget.Alive)
			{
				Console.WriteLine("The Batman is fighting " + currentTarget.Name + " remaing health " + currentTarget.Health);
				Console.WriteLine("What do you do? (fight, flee)");
				string action = Console.ReadLine();
				if (action == "fight") 
				{
					currentTarget.Attack();
				} else if (action == "flee") 
				{
					Console.WriteLine("The Batman never flees!");
				} else {
					Console.WriteLine("Stop jokin around");
				}
			}
			Console.WriteLine("You have defeated " +currentTarget.Name);
    }
  }
}
