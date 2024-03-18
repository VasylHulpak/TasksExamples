
using System.Diagnostics;

static async Task Task1()
{
    int sum = 0;
    foreach (var counter in Enumerable.Range(0, 30))
    {
        sum += counter;
        await Task.Delay(300);
    }
 
    Console.WriteLine("Task1", sum);
}

static async Task Task2()
{
    int sum = 0;
    foreach (var counter in Enumerable.Range(0, 40))
    {
        sum += counter;
        await Task.Delay(200);
    }
    
    Console.WriteLine("Task2", sum);
}

static async Task Task3()
{
    int sum = 0;
    foreach (var counter in Enumerable.Range(0, 50))
    {
        sum += counter;
        await Task.Delay(300);
    }
    
    Console.WriteLine("Task2", sum);
}

var stopwatch = new Stopwatch();
stopwatch.Start();
 
await Task1();
await Task2();
await Task3();
Console.WriteLine("Time1..." + stopwatch.Elapsed);
stopwatch.Stop();
stopwatch.Start();
var stopwatch1 = new Stopwatch();
stopwatch1.Start();
 
var t1 = Task1();
var t2 = Task2();
var t3 = Task3();
await Task.WhenAll(t1, t2, t3);

Console.WriteLine("Time2..." + stopwatch1.Elapsed);
 
Console.Read();
