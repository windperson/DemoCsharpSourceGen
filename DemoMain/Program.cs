namespace DemoMain;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        HelloFrom("Source Generator");
    }

    static partial void HelloFrom(string name);
}
