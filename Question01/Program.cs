namespace Question
{
    class Program
    {
        static void result(String title)
        {

            string[] arr = title.Split(" ");
            

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 2)
                {
                    Console.Write(arr[i].ToLower());
                }
                else
                {
                    Console.Write((arr[i].ToUpper())[0]);
                    Console.Write(arr[i].ToLower().Remove(0, 1));
                }
                Console.Write(" ");

            }

        }


        public static void Main(string[] args)
        {
            Console.Write("Enter Sentence: ");
            String title = Console.ReadLine();
            

            result(title);
        }

    }

}
