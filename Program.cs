namespace Kata1;

//Striped Yellow Belt kata1
class Program
{
    static void Main(string[] args)
    {
        // Character classes
        Warrior warrior = new Warrior("Mathias", 60); 
        Healer healer = new Healer("Freya", 70);

        
        Character[] characters = new Character[]
        {
            new Character { Name = "Mathias", Health = warrior.Health },
            new Character { Name = "Freya", Health = healer.Health }
        };

        

        //Actions based on health
        for (int round = 1; round <= 5; round++)
        {
            Console.WriteLine($"*-*-* Battle {round} *-*-*");

            
            if (warrior.Health < 50)
            {
                warrior.PerformAction();
            }

            
            healer.PerformAction(characters);

            
            warrior.Health -= 15;
            healer.Health -= 10;
            characters[0].Health = warrior.Health;
            characters[1].Health = healer.Health;

            Console.WriteLine($"Status - Warrior Health: {warrior.Health}, Healer Health: {healer.Health}\n");
        }

        Console.WriteLine("Combat ended.");
    }
}
