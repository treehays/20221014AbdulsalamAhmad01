namespace Question
{
    class Program
    {
        static int result(int num2, int num1)
        {
            int count = 0;
            while (num1 != 0 && num2 != 0)
            {
                if (num1 >= num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }
                ++count;
            }
            return count;
        }


        public static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result(num1, num2));
        }

    }

}
