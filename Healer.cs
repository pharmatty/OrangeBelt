namespace Kata1;

public class Healer
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Action<Character[]> PrimaryAction { get; set; }

    public Healer(string name, int health)
    {
        Name = name;
        Health = health;

        
        PrimaryAction = (characters) =>
        {
            
            var target = characters.OrderBy(c => c.Health).FirstOrDefault(c => c.Health > 0);
            if (target != null)
            {
                Console.WriteLine($"{Name} heals {target.Name} for 30 health.");
                target.Health += 30;
            }
        };
    }

    public void PerformAction(Character[] characters)
    {
        PrimaryAction.Invoke(characters);
    }
}
