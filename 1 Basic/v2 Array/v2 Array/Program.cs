// See https://aka.ms/new-console-template for more information

string[,] books = new string[3, 2]
{
    {"book1", "123" },
    {"book2", "234" },
    {"book3", "456" }
};

int upperBound = books.GetUpperBound(0);
int upperBound2 = books.GetUpperBound(1);

for (int i = 0; i <= upperBound; i++)
{
    for (int j = 0; j <= upperBound2; j++)
    {
        Console.WriteLine(books[i, j]);
    }
}















/*

string[] filmtitlarna = {"Titanic", "Lion King",
"Borat", "Jurassic Park", "Dictator"};
Array.Sort(filmtitlarna);
for(int i = 0; i < filmtitlarna.Length; i++)
{
    Console.WriteLine(filmtitlarna[i]);
}

















/*int[] numbers = { 12, 52, 74 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine(sum);




















/*
string[] cars = { "Ford", "Cadillac", "Audi" };
Array.Sort(cars);

Console.WriteLine(cars[0]);
Console.WriteLine(cars[1]);
Console.WriteLine(cars[2]);


















/*string[] games = new string[] {"Tera", "Aion",
"WoW", "Witcher", "DragonAge"};
foreach (string game in games)
{
    Console.WriteLine(game);
}
*/