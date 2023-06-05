namespace Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine("i body");
            //    Console.WriteLine("i = " + i);
            //    for(int j=0; j<5; j++)
            //    {
            //        Console.WriteLine("j = " + j);
            //    }
            //}

            
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