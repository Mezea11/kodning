using App;

Player p1;
Player p2;

p1 = new Player();
p2 = new Player();

p1.HP = 20;
p2.HP = 30;

p1.MainHand = new Weapon();
p2.MainHand = new Weapon();

p1.MainHand.DMG = 3;
p2.MainHand.DMG = 4;

p1.TakeDamage();

Console.WriteLine($"P1 STATS:");
p1.PrintStats();

Console.WriteLine($"P2 STATS:");
p2.PrintStats();
