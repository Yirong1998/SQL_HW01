// See https://aka.ms/new-console-template for more information
// 1. long; float; int; bool; double; long; double; double; int; long; ulong; int
// 2. Value Type directly hold the value, but Reference Type hold the memory address for this value.
// Boxing is to convert a value type to a reference type. Unboxing is to convert a reference type to a value type.
// 3. Unmanaged resource is something not directly under the control of the garbage collector.
// Managed resource is pure .Net code and managed by the runtime and is under direct control.
// Garbage Collector is an automatic memory manager.It manages the allocation and release of memory.
using System;

public class P1
{
    public static void Main()
    {
        // Q1
        string[] types = { "sbyte", "byte", "short", "ushort",
                         "int", "uint", "long", "ulong", "float", "double", "decimal" };
        int[] bytesnum = { sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort),
                         sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal)};
        object[] maxv = {sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue,
                     int.MaxValue, uint.MaxValue, long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, decimal.MaxValue};
        object[] minv = {sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue,
                     int.MinValue, uint.MinValue, long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, decimal.MinValue };

        Console.WriteLine("{0,-7} {1,10} {2,20} {3,30}\n", "bytes", "bytes num", "min", "max");
        for (int ctr = 0; ctr < types.Length; ctr++)
            Console.WriteLine("{0,-7} {1,10} {2,20} {3,30}", types[ctr], bytesnum[ctr], minv[ctr], maxv[ctr]);
        // Q2
        Console.WriteLine("enter number of centuries:");
        int centuries = Convert.ToInt32(Console.ReadLine());
        object[] res = timeFromCentury(centuries);
        for (int ctr = 0; ctr < 8; ctr++)
            Console.WriteLine(res[ctr]);
        // Q3
        var t = new P1();
        int num = 100;
        t.exercise03(num);
        Console.ReadLine();

        //Infinity loop
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            if (i == byte.MaxValue)
            {
                Console.WriteLine(i+" reach the max value");
                break;
            }
            Console.WriteLine(i);
        }

        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("GUESS A NUMBER:");
        int gn = Convert.ToInt32(Console.ReadLine());
        if (gn == correctNumber)
        {
            Console.WriteLine("Correct");
        }
        else if (gn < correctNumber)
        {
            Console.WriteLine("low");
        }
        else if (gn > correctNumber)
        {
            Console.WriteLine("high");
        }
        else if (gn < 1 || gn > 3)
        {
            Console.WriteLine("Outside of Range");
        }

        for (int i = 1; i <= 5; i++)
        {
             for (int j = 1; j <= (5 - i); j++) // Loop For Space  
                   Console.Write(" ");
             for (int j = 1; j <= i; j++) //increase the value  
                   Console.Write('*');
             for (int j = (i - 1); j >= 1; j--) //decrease the value  
                   Console.Write('*');
             Console.WriteLine();
        }

        DateTime dt = new DateTime(2005, 10, 11);
        DateTime now = DateTime.Now;
        TimeSpan ts = now - dt;
        int days = Math.Abs(ts.Days);
        Console.WriteLine("Days: "+days);

        DateTime time = DateTime.Now;
        if (time.Hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (time.Hour < 18 && time.Hour >= 12)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (time.Hour < 24 && time.Hour >= 18)
        {
            Console.WriteLine("Good Evening");
        }
        
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j = j + i)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }

    // Q2
    public static object[] timeFromCentury(int century)
    {
        int years = century * 100;
        int days = century * 36524;
        int hours = century * 876576;
        int minutes = century * 52594560;
        long seconds = century * 3155673600;
        long milliseconds = century * 3155673600000;
        long microseconds = century * 3155673600000000;
        long nanoseconds = century * 3155673600000000000;
        //return (a:years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds); 
        object[] res = {years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds};
        return res;

    }

    // 1. Compile time error.
    // 2. Infinity.
    // 3. The result wraps.
    // 4. ++y means when code is executing it will first do y = y + 1 and then read it.
    //    y++ means when code is executing it will first read it and do the y = y + 1 after it has been read.
    // 5. Break: it breaks the loop. Continue: it skips the execution of current iteration only and it does not 
    //           break the loop. It passes the control to the next iteration of the enclosing loop. Return: it will
    //           exit the current method.
    // 6. initialization, condition, and iterator which all are required.
    // 7. == is the comparison operator which return boolean value. = is an assignment operator which is used to 
    //    assign the value on the right to the variable on the left.
    // 8. Yes.
    // 9. It replaces the default keyword to signify that it should match anything if reached.
    // 10. IEnumerable<T> defines one method: GetEnumerator()

    // E3.
    public void exercise03(int num)
    {
        for(int i = 1; i < num; i++)
        {
            if (i%3 == 0 && i%5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i%3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i%5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    


}
