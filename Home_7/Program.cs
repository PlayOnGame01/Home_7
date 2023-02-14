using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Home.Net_09_02
{
    internal class Program
    {
        static void Compare(int a, int b, string symb)
        {
            string[] mass = new string[] { ">", "<", "<=", ">=", "!=", "==" }; int count = 0;
            try
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (symb == mass[i])
                    {
                        count++;
                    }
                }
                if (count != 1)
                {
                    throw new Exception("It's uncorrect sign!");
                }
                switch (symb)
                {
                    case "<":
                        if (a < b == true) { Console.WriteLine($"{a} {symb} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;
                    case ">":
                        if (a > b == true) { Console.WriteLine($"{a} {symb} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;
                    case ">=":
                        if (a >= b == true) { Console.WriteLine($"{a} {symb} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;
                    case "<=":
                        if (a <= b == true) { Console.WriteLine($"{a} {symb} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;
                    case "==":
                        if (a == b == true) { Console.WriteLine($"{a} {symb} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;
                    case "!=":
                        if (a != b == true) { Console.WriteLine($"{a} {symb} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter boolean expression: ");
            string str = Console.ReadLine();
            string[] textArray = str.Split(new char[] { ' ' });
            int a = Convert.ToInt32(textArray[0]);
            int b = Convert.ToInt32(textArray[2]);
            string symbol = null;
            string[] mass = new string[] { "<", ">", "=", "!" };
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (Convert.ToString(str[i]) == mass[j])
                    {
                        symbol = Convert.ToString(str[i]);
                        if (str[i + 1] == '=') { symbol += str[i + 1]; i = str.Length; j = mass.Length; }
                    }
                }
            }
            Compare(a, b, symbol);
        }
    }
}