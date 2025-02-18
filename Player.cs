class Player
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int AttackPower { get; set; } = 10;
        public int AttackDefence { get; set;} = 0;
        public List<Items> Inventory { get; set; } = new List<Items>();
        
        public void AddToInventory(){
            Items item =Items.GenetrateRandomItem();
            Inventory.Add(new Items(item.Name, item.Health, item.AttackPower, item.DefencePower));
        }

        public void ShowInventory(){

            if (Inventory.Count > 0){
                foreach (var item in Inventory){
                    Console.WriteLine(item.Name);
                    Console.WriteLine("Use an item? (yes/no)");
                    string useItem = Console.ReadLine().ToLower();
                    switch (item.Name){
                        case "potion":
                            Health += 10;
                            Console.WriteLine("added health");
                            break;
                        case "super potion":
                            Health += 50;
                            Console.WriteLine("added health");
                            break;
                        case "sword":
                            AttackPower += 10;
                            Console.WriteLine("Equipped sword");
                            break;
                        case "shield":
                            AttackDefence += 10;
                            Console.WriteLine("Equipped shield");
                            break;
                        case "master sword":
                            AttackPower += 50;
                            Console.WriteLine("Equipped Masetr Sword");
                            break;                    
                    }
                
            }
            }else{
                Console.WriteLine("You don't have any items");
            }
        }

        public void Attack(Enemy enemy)
        {
            Console.WriteLine($"You attack the {enemy.Name} for {AttackPower} damage!");
            enemy.Health -= AttackPower;
        }
    }