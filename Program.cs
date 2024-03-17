internal class Program
{
    private static void Main(string[] args)
    {
        string[] array1 = new string[5] { "1234", "1567", "-2", "computer science", ":-)" };
        string[] array2 = new string[array1.Length];

            for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
                }

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
        SecondArrayWithIF(array1, array2);

        for (int i = 0; i < array2.Length; i++)
                {
                    Console.WriteLine(array2[i]);
                }
    }
}