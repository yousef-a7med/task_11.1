internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Rows Number");
        int Rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Columns Number");
        int Columns = int.Parse(Console.ReadLine());

        int[,] array = new int[Rows, Columns];
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.WriteLine("Enter Value");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.WriteLine(array[i, j]);
                
            }
        }
    }
}