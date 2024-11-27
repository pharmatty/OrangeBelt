namespace Kata1;
public class Warrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Action PrimaryAction { get; set; }

    public Warrior(string name, int health)
    {
        Name = name;
        Health = health;

        
        PrimaryAction = () => Console.WriteLine($"{Name} strikes the enemy with a mighty attack!");
    }

    public void PerformAction()
    {
        PrimaryAction.Invoke();
    }
}
