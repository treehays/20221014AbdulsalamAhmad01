namespace Question
{
    class Program
    {
        // Second Method if youre returning lists
        static List<string> result(String title)
        {
            var titls = title.ToLower();
            string[] arr = titls.Split(" ");
            var listOfWords = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 2)
                {
                    listOfWords.Add(arr[i] + ' ');
                }
                else
                {
                    listOfWords.Add((arr[i].ToUpper())[0] + (arr[i].Remove(0, 1)) + ' ');
                }
            }
            return listOfWords;
        }
        // Second Method if youre returning string
        static string result2(String title)
        {
            var titls = title.ToLower();
            string[] arr = titls.Split(" ");
            var listOfWords = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 2)
                {
                    listOfWords.Add(arr[i] + ' ');
                }
                else
                {
                    listOfWords.Add((arr[i].ToUpper())[0] + (arr[i].Remove(0, 1)));
                }
            }
            var resul = String.Join(' ', listOfWords);
            return resul;
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter Sentence: ");
            String title = Console.ReadLine();
            Console.WriteLine(result2(title));
            
            // foreach (var item in result2(title))
            // {
            //     Console.Write(item);
            // }
        }
    }
}
