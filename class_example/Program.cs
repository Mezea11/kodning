using MyApp;
using MyApp2;

Clothing item1 = new Clothing();
Clothing item2 = new Clothing();


item1.name = "Shirt";
item1.color = "Blue";
item1.size = 543;

item2.name = "Coat";
item2.color = "Red";
item2.size = 533;

User user1 = new User("Christian", 29);

Console.WriteLine(user1.Info());

item1.WriteLine(); //object method invoked
item2.WriteLine(); //object method invoked


string item1_description = item1.Description();

Console.WriteLine(item1_description);