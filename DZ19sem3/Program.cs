using System;
using static System.Console;

namespace SEM_PROG3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите число");
            int dig = Convert.ToInt32(ReadLine());
            WriteLine(Palindrome(dig));
            ReadKey();
        }
        
        static bool Palindrome(int num)
        {
            if (num >= 0 && num <10)
                return true;
            int numLength = GetLength(num);
            int[] digit = new int[numLength];
            for (int i = numLength - 1; i >= 0; i--) {
                digit[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength/2; i++) {
                if (digit[i] != digit[numLength - i - 1])
                    return false;
            }
            return true;
        }
        
        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0) {
                num /= 10;
                n++;
            }
            return n;
        }
    }
}