// See https://aka.ms/new-console-template for more information
using Skapa_ett_spel2;

Villager andrian = new Villager("Andrian", "elf", "magician");
Monster sovuh = new Monster(100, "Sovuh", 10, 10, "fire");
Villager Sam = new Villager("Sam", "elf", "magician");

Menu();
void Menu()
{
    bool success = true;
    while (success)
    {
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Trade");

        int input = Int32.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                andrian.Attack(sovuh);
                break;
            case 2:
                Menu2();
                break;
        }
    }
}
void Menu2()
{
    bool success = true;

    Console.WriteLine("1. Apple");
    Console.WriteLine("2. Armor");

    int input = Int32.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:

            andrian.Trade("Apple");
            break;
        case 2:
            andrian.Trade("Armor");
            break;
    }
    Menu();
}
//andrian.Attack(sovuh);
//andrian.Attack(sovuh);
//andrian.Attack(sovuh);
//andrian.Attack(sovuh);
//andrian.Attack(sovuh);
//andrian.Eat();
//andrian.Trade("Apple");