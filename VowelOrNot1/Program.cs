using System;

namespace VowelOrNot;

class Program
{
    public static char[] array = { 'a', 'e', 'i', 'o', 'u', 'ა', 'ე', 'ი', 'ო', 'უ' };

    public static bool IsVowel(char c)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (c == array[i])
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsVowel('a'));
    }
}