namespace Project_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Compute the first 25 numbers of the Fibonacci Sequence");

            int[] fibo = new int[25];
            fibo[0] = 0;
            fibo[1] = 1;

        

            for (int i = 0; i < 25; i++)
            {
                if (i >= 2) 

                {
                    fibo[i] = fibo[i - 2] + fibo[i - 1];
                }

                Console.WriteLine(fibo[i]);
            }

            
        }
    }
}
