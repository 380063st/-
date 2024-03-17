internal class Program
{
    private static void Main(string[] args)
    {
        string[] array1 = new string[5] { "1234", "1567", "-2", "computer science", ":-)" };
        string[] array2 = new string[array1.Length];

        void SecondArrayWithIF(string[] array1, string[] array2)
        {
            int index = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <= 3)
                {
                    array2[index] = array1[i];
                    index++;
                }
            }
        }

         void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        PrintArray(array1);
        SecondArrayWithIF(array1, array2);
        PrintArray(array2);
    }
}