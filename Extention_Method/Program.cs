

public static class Extention_Method
{
    public static void SayHallo(this string name)
    {
        Console.WriteLine(name);
    }
    public static void Increas(this int num)
    {
        Console.WriteLine(++num);
    }
    public static void Decreas(this int num)
    {
        Console.WriteLine(--num);
    }
    public static void Foreach(this int[] num)
    {
        foreach (var item in num)
        {
            Console.WriteLine(item);
        }
    }
    public static void Mysum(this int[] num)
    {
        int sum = 0;
        foreach (var item in num)
        {
            sum += item;
            Console.WriteLine(sum);
        }
    }


}
internal class Program
{
    private static void Main(string[] args)
    {
        string Name="yousef";
        Name.SayHallo();
        int num = 5;
        num.Increas();
        num.Decreas();
        int[] nums = [ 1, 2, 3, 4, 5,55,32,45 ];
        nums.Foreach();
        nums.Mysum();
    }
}