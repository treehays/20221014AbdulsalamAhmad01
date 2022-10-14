string title = "hgFirst Letter of EFDach word";

string[] arr = title.Split(" ");
// string temp = "";

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
