// See https://aka.ms/new-console-template for more information

class Banana
{

}
class Program
{
    static async Task Main(string[] args)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        //Task[] bananaMethods = { BananaMakingLong(), BananaMakingShort() };

        Banana val = await BananaMakingLong();
        Banana val2 = await BananaMakingShort();
        //try 
        //{
        //    Task.WaitAll(bananaMethods);
        //}5
        //catch (Exception ex)
        //{ 
        //    Console.WriteLine(ex.ToString());
        //}

        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;

        Console.WriteLine(elapsedMs.ToString());

        Console.ReadKey();
    }

    static async Task<Banana> BananaMakingLong()
    {
        Console.WriteLine("Process long started");
        await Task.Delay(10000);
        Console.WriteLine("Process long completed");
        return new Banana();
    }
    static async Task<Banana> BananaMakingShort()
    {
        Console.WriteLine("Process short started");
        await Task.Delay(3000);
        Console.WriteLine("Process short completed");
        throw new ArgumentNullException();
        return new Banana();
    }
}