class Game
    {
        public static void Start()
        {
            Console.WriteLine("Welcome to the Dungeon!");
            Console.Write("Enter your character's name: ");
            string playerName = Console.ReadLine();
            Player player = new Player { Name = playerName};
            
            while (player.Health > 0)
            {   
                Console.WriteLine("Enemy ahead!/n What will you do?\n fight/items");
                string decision = Console.ReadLine().ToLower();
                switch (decision)
                {
                    case "fight":
                        Console.WriteLine($"{player.Name}! Prepare for battle.");
                        break;
                    case "items":
                        Console.WriteLine("List of items");
                        player.ShowInventory();
                        Console.WriteLine("Use an item? yes/no");
                        string ItemUse = Console.ReadLine().ToLower();
                        if (ItemUse == "yes"){
                            player.UseItem();
                            }
                        break;
                }
                Enemy enemy = Enemy.GenerateRandomEnemy();
                Console.WriteLine($"A {enemy.Name} appears!");
                
                while (player.Health > 0 && enemy.Health > 0)
                {
                    Console.WriteLine("What will you do? (attack/flee)");
                    string action = Console.ReadLine().ToLower();
                    
                    if (action == "attack")
                    {
                        player.Attack(enemy);
                        if (enemy.Health > 0)
                        {
                            enemy.Attack(player);
                        }
                        else
                        {
                            Console.WriteLine($"You defeated the {enemy.Name}!");
                        }
                    }
                    else if (action == "flee")
                    {
                        Console.WriteLine("You fled the battle!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid action. Try again.");
                    }
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine("You have been defeated. Game over.");
                    break;
                }

                Console.WriteLine("Do you want to continue exploring? (yes/no)");
                string continueGame = Console.ReadLine().ToLower();
                if (continueGame != "yes")
                {
                    Console.WriteLine("You leave the dungeon. Game over.");
                    break;
                }
            }
        }
    }