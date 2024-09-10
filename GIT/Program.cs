using System.ComponentModel;

namespace GIT;

internal class Program
{
    static void Main(string[] args)
    {
        int changeThisLater = 10;

        int result = RemoveInsteadOfAdd(1, 2);
        int result2 = RemoveInsteadOfAdd(1, 2);
        int result3 = RemoveInsteadOfAdd(1, 2);


        DoSomething2();
        DoSomething2();
        DoSomething2();
        DoSomething2();

      
      
      
    }

    private static void DoSomething2()
    {
       
    }

    private static int RemoveInsteadOfAdd(int x, int y)
    {
        return x + y;
    }
}
