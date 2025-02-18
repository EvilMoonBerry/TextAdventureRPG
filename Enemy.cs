 class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Enemy(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public void Attack(Player player)
        {
            Console.WriteLine($"The {Name} attacks you for {AttackPower} damage!");
            player.Health -= AttackPower;
        }

        public static Enemy GenerateRandomEnemy()
        {
            List<Enemy> enemies = new List<Enemy>
            {
                new Enemy("Goblin", 50, 5),
                new Enemy("Skeleton", 60, 8),
                new Enemy("Orc", 80, 10),
                new Enemy("Dark Wizard", 40, 12)
            };
            Random rand = new Random();
            return enemies[rand.Next(enemies.Count)];
        }
    }