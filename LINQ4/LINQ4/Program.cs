// See https://aka.ms/new-console-template for more
using System.Text.RegularExpressions;



string webAdress = "www.matmats.se";
var regEx = new Regex(@"^www\.[a-z0-9]+\.[a-z]+$");
Console.WriteLine(regEx.IsMatch(webAdress));
















/*























string epost = "evgenyprib@gmail.com";
var regEx2 = new Regex(@"^[a-zA-Z0-9!#$%&'*+-/= ? ^ _ ` { |]+@[a-zA-Z0-9-.\]+[a-zA-Z0-9-]+$");
Console.WriteLine(regEx2.IsMatch(epost));









































/*
var input = "+46790268232";
var regEx3 = new Regex(@"\+46\d{9}");
Console.WriteLine(regEx3.IsMatch(input));

/*
string text = "Idag är det             onsdag!";

string res = Regex.Replace(text, @"\s+", " ");
Console.WriteLine(res);
var result = Regex.Match(res, @"onsdag");
Console.WriteLine("Hittade " + result.Value + " at index" + result.Index);

/*
string text = "med mål";
// () = matchar tecknen m och å i följd
var result = Regex.Match(text, @"(må)");
Console.WriteLine("Hittade \"" + result.Value + "\" på index" + result.Index);


/*

Console.WriteLine($"Textsträng: {text}.");
// \s = matchar mellanslag
// + = matchar föregående tecken som förekommer fler än en gång
string result = Regex.Replace(text, @"\d+", "siffra");
// ^---^ ^---^ ^-^
// 1) 2) 3)
//
// 1. Textsträng (den textsträng vi vill bearbeta)
// 2) Reguljärt uttryck = fler än ett mellanslag
// 3) Mellanslag (byt ut mot mellanslag)
Console.WriteLine($"Ny textsträng: {result} (inte längre).");


/*
var catHotel = new List<Room>() { new Room(new Cat("Aurora", 2), 1), new Room(new Cat("Jones", 1), 2), new Room(new Cat("Ylva", 5), 3) };
var query = catHotel.SelectMany(room => room.Cats.Where(cat => cat.Age > 5).Select(cat => cat.Name + " i rum " + room.Number + " är " + 
cat.Age + " år gammal" + "och hör till de katter som är äldre än 5 år."));
foreach (var cat in query)
{
    Console.WriteLine(cat);
}
class Room
{
    public int Number { get; set; }
    public List<Cat> Cats { get; set; }
    public Room(Cat cat, int number)
    {
        Cats = new List<Cat>()
        {
            new Cat("Herman", 12),
            new Cat("Edith", 7),
            new Cat("Noel", 5),
            new Cat("Serge", 3)
        };

        Cats.Add(cat);
        Number = number;
    }
}

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

/*
var numbers = new int[] { 43, 42, 57, 23, 24, 25, 65, 64, 34, 12, 13, 14, 1, 3, 2, };
var numbersHigherThan30 = numbers.Where(x => x > 30);
Console.WriteLine("Medelvärdet av alla tal större än 30 är " + numbersHigherThan30.Average());
Console.WriteLine("Antal tal större än 30 är " + numbersHigherThan30.Count());
Console.WriteLine("Summan av alla tal större än 30 är " + numbersHigherThan30.Sum());
Console.WriteLine("Minsta talet är " + numbersHigherThan30.Min());
Console.WriteLine("Största talet är " + numbersHigherThan30.Max());



var agents = new Agent[] {
new Agent("Smith", "M100"),
new Agent("Williams", "M200"),
new Agent("Smith", "M300"),
new Agent("Anderson", "M400"),
new Agent("Jones", "M500"),
new Agent("Smith", "M700"),
new Agent("Johnsson", "M700"),
new Agent("Jones", "M600")
};

var agentsByName = from agent in agents
                   group agent by agent.Name;
foreach(var agentGroup in agentsByName)
{
    foreach (var agent in agentGroup)
    {
        Console.WriteLine("Name: " + agent.Name + ". Code:" + agent.Code);
    }
}
Console.ForegroundColor = ConsoleColor.Green;

public class Agent
{
    public string Name { get; set; }
    public string Code { get; set; }
    public Agent(string name, string code)
    {
        Name = name;
        Code = code;
    }
}



//------------------------------------------------
// Product-klass
//------------------------------------------------
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}




var numbers = new int[] { 99, 33, 22, 51, 71, 81, 32, 52, 62 };
numbers.Where(x => x > 50).ToList().ForEach(x => Console.WriteLine(x));



//------------------------------------------------
// Array innehållande Book
//------------------------------------------------
var books = new Book[] {
new Book("August Strindberg", "Röda Rummet"),
new Book("Paulo Coelho", "Alkemisten"),
new Book("August Strindberg", "Inferno"),
new Book("Paulo Coelho", "Valkyriorna"),
new Book("Selma Lagerlöf", "Gösta Berlings saga"),
new Book("Per Anders Fogelström", "Mina drömmars stad"),
new Book("Selma Lagerlöf", "Nils Holgerssons underbara resa genom Sverige"),
new Book("Hjalmar Söderberg", "Doktor Glas"),
new Book("Tove Folkesson", "Kalmars jägarinnor"),
new Book("Johannes Anyury", "En storm kom från paradiset")
};
books.Where(book => book.Author == "Hjalmar Söderberg" || book.Author == "August Strindberg" || book.Author == "Per Anders Fogelström")
    .ToList().ForEach(book => Console.WriteLine("Från Stockholm:" + book.Author));
//------------------------------------------------
// Bok-klass
//------------------------------------------------
public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public Book(string author, string title)
    {
        Author = author;
        Title = title;
    }
}
*/
