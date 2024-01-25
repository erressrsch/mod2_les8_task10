using System;
class Program
{
    static void Main()
    {
        int a = 12;
        int b = 23;

        if(a <= 0 || b <= 0)
        {
            Console.WriteLine("Both input values must be greater than 0.");
            return;
        }

        int valueA = a;
        int valueB = b;
        int valueNWW = default;
        int valueNWD = 1;

        for(int i = 0; valueA != valueB; i++)
        {
            if (valueA > valueB)
            {
                valueA = (valueA - valueB);
            }
            else if (valueA < valueB)
            {
                valueB = (valueB - valueA);
            }

        }

        valueNWD = valueA;

        valueNWW = (a * b) / valueNWD;

        Console.WriteLine($"\"NWW\" For {a} & {b} = {valueNWW}");

    }
}