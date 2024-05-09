using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

public static class Program
{
    public static void Main(string[] args)
    {
               
    }
    public static string IsPangram(string str)
    {
        str = str.ToLower();
        List<char> alphabet = new List<char>{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < alphabet.Count; j++)
            {
                if (str[i] == alphabet[j])
                {
                    alphabet.RemoveAt(j);
                    break;
                }
            }
        }

        return String.Join(" ", alphabet);
        // return alphabet.Count == 0 ? true : false;
    }
    public static int[] MoveZeroes(int[] arr)
    {
        var withOutZero = arr.Where(x => x != 0).ToList();
        foreach (var item in arr)
        {
            if(item == 0) withOutZero.Add(0);
        }
        return withOutZero.ToArray();
    }
    public static string ExpandedForm(long num)
    {
        var str = num.ToString();
        string zero = String.Empty;
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length - i - 1; j++)
            {
                zero += "0";
            }
            if(str[i] != '0')
                result += str[i] + zero + " ";
            zero = String.Empty;
        }

        result = result.Replace(" ", " + ");
        return result.Remove(result.Length - 3);
    }

    public static int Find(int[] integers)
    {
        
        var isOdd = integers.Where(x => x % 2 == 0);
        if (isOdd.ToList().Count > 2)
        {
            var odd = integers.Where(x => x % 2 != 0);
            return odd.ToList()[0];
        }
        else
        {
            var noOdd = integers.Where(x => x % 2 == 0);
            return noOdd.ToList()[0];
        }
    }
    public static int DigitalRoot(long n)
    {
        if (n.ToString().Length < 2)
            return GetSumOfString(n);
        long res = GetSumOfString(n);
        return DigitalRoot(res);

    }

    public static int GetSumOfString(long n)
    {
        int sum = 0;
        for (int i = 0; i < n.ToString().Length; i++)
        {
            sum += Int32.Parse(n.ToString()[i].ToString());
        }
        return sum;
    }
    public static bool XO(string input)
    {
        input = input.ToLower();
        if (input.Count(x => x == 'x') == input.Count(x => x == 'o'))
            return true;
        return false;
    }
    public static int DontGiveMeFive(int start, int end)
    {
        List<string> list = new List<string>();
        for (int i = start; i <= end; i++)
            list.Add(i.ToString());

        return list.Where(x => !x.Contains('5')).Count();
    }
}
}