// See https://aka.ms/new-console-template for more information

class Apple
{ }

class Program
{
    static async Task Main(string[] args)
    {
        var Task1 = LongProcess();
        var Task2 = ShortProcess();

        List<Task> tasks = new List<Task>();

        tasks.Add(Task1);
        tasks.Add(Task2);

        Task.WaitAll(tasks.ToArray());
        Console.ReadKey();
    }
    

    static async Task<Apple> LongProcess()
    {
        Console.WriteLine("long proccess started");
        await Task.Delay(4000);
        Console.WriteLine("long process completed");
        return new Apple();
    }

    static async Task<Apple> ShortProcess()
    {
        Console.WriteLine("short proccess started");
        await Task.Delay(1000);
        Console.WriteLine("short process completed");
        return new Apple();
    }
}
