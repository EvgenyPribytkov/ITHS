// See https://aka.ms/new-console-template for more information

List<Monster> monsterList =
new List<Monster>()
{
new Monster("Gromp", 100, false),
new Monster("Cranky", 120, true),
new Monster("CoffeeSpiller", 35, false)
};

//Använd SELECT och FOREACH för att skriva ut alla namn på monstrena (det är en bra ide att lägga in
//alla monsternamn i en var eller List<string> om ni vill ha en temporär variabel).

List<string> monstersNames = monsterList.Select(x => x.Name).ToList();
monstersNames.ForEach(x => Console.WriteLine(x));

//Använd WHERE, SELECT och FOREACH för att skriva ut alla monster med mer än 50 health.
List<string> monstersWithHealthAbove50 = monsterList.Where(monster => monster.Health > 50)
                                                    .Select(monster => monster.Name).ToList();
monstersWithHealthAbove50.ForEach(x => Console.WriteLine(x));

// Använd WHERE, SELECT och FOREACH för att skriva ut alla monster som inte är döda.
List<string> monstersAlive = monsterList.Where(monster => monster.isDead == false)
                                        .Select(monster => monster.Name).ToList();
monstersAlive.ForEach(x => Console.WriteLine(x));
//Använd SELECT, ORDERBY och FOREACH för att skriva ut alla namn i ascending order.
List<string> monstersNamesAscending = monsterList.Select(x =>x.Name).OrderBy(x => x).ToList();
monstersNamesAscending.ForEach(x => Console.WriteLine(x));
class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }
    public bool isDead { get; set; }
    public Monster(string name,
    int health, bool isDead)
    {
        Name = name;
        Health = health;
        this.isDead = isDead;
    }
}
