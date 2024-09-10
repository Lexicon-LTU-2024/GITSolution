using System.ComponentModel;

namespace GIT;

internal class Program
{
    static void Main(string[] args)
    {


        int result = Banan(1, 2);
        int result2 = Banan(1, 2);
        int result3 = Banan(1, 2);


        DoSomething();

      
      
    }

    private static void DoSomething()
    {
        int x = 5;
        Console.Write(x);
    }

    private static int Banan(int x, int y)
    {
        return x + y;
    }
}
