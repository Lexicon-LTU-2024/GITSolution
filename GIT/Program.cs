using System.ComponentModel;

namespace GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 1;
            int y = 2;

            if (x != y)
            {
                //
                int v = 3;

            }

            int result = Add(x, y);

            int temp = 0;
            for (int i = 0; i < 10000; i++)
            {
                //Other code
                temp = i;
            }
          
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
