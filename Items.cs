class Items{

    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int DefencePower{ get; set; }


    public Items(string name, int health, int attackPower, int defencePower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        DefencePower = defencePower;
    }


    public static Items GenetrateRandomItem()
        {
            List<Items> items = new List<Items>
            {
                new Items("Potion",10,0,0),
                new Items("Super Potion",50,0,0),
                new Items("Sword",0,10,0),
                new Items("Shield",0,0,10),
                new Items("Master Sword",0,0,10)
            };
            Random rand = new Random();
            return items[rand.Next(items.Count)];
        }


}