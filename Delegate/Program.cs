
public delegate bool checkNum(int num);
public delegate int MySum(int num1,int num2);
public class CheckNumbers 
{ 
    public void Check(int[] nums, checkNum ch)
    {
        foreach(int item in nums)
        {  
            if (ch(item))
              {
                Console.WriteLine(item);
              }
        }
    }

    public void calculation (int num1,int num2,MySum s)
    {
        int result = s(num1,num2);
        Console.WriteLine(result);
    }

}

internal class Program
{
    static bool positive(int num)
    {
        return num > 0;
    }

    static bool negative(int num)
    {
        return num < 0;
    }
    static bool Even(int num)=> num % 2 == 0;
    
    static bool odd(int num)=> num % 2 != 0;
    
    private static void Main(string[] args)
    {
        CheckNumbers c = new CheckNumbers();
        checkNum ch = new checkNum(positive);
        c.Check ([1, 2, 4, 24, 33, 13, -5, -21, 16, -74, -32, 20],ch);

        checkNum ch1 = new checkNum(negative);
        c.Check([1, 2, 4, 24, 33, 13, -5, -21, 16, -74, -32, 20], ch1);

        checkNum ch2 = new checkNum(Even);
        c.Check([1, 2, 4, 24, 33, 13, -5, -21, 16, -74, -32, 20], ch2);

        checkNum ch3 = new checkNum(odd);
        c.Check([1, 2, 4, 24, 33, 13, -5, -21, 16, -74, -32, 20], ch3);

        c.calculation(10, 20, (a, b) => a + b);

    }
}