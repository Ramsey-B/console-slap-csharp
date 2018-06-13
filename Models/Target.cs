namespace csharp_intro.Models
{
  class Target //classes always start with capitals
  {
    public float Health { get; private set; }//public makes it public, private makes it only accessible to its parent class
    public string Name { get; private set; }

    public bool Alive { get; private set; } = true;

    public Target(string name, int health)
    {
      Name = name;
      Health = health;
    }
    public void Attack()//void means method returns nothing. Methods must declare what they return
    {
      Health -= 1;
      if (Health <= 0)
      {
        Alive = false;
        Health = 0;
      }
    }

  }
}