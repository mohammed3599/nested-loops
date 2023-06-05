namespace Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********");
            /*Print the following pattern
             
             *
             **
             ***
             ****
             *****
             ******
             *******
             ********
             *********
             **********
             
                             */
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 0; j < i;  j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /*Print the following pattern
             *********
             ********
             *******
             ******
             *****
             ****
             ***
             **
             *
             
                   */
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**********");

        }
    }
}