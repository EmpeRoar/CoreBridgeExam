using System;

namespace CoreBridge.ConsoleApp
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine();

        //    Console.WriteLine(input);

        //}

        //public static bool IsValid(string str)
        //{
        //    if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (IsValid(input))
            {
                char[] r = input.ToCharArray();
                Array.Sort(r);
                Array.Reverse(r);
                var sort = Sort(r);
                var newStr = string.Join("", sort);
                Console.WriteLine(newStr);

            }
            Console.ReadLine();
        }

        public static char[] Sort(char[] convertedStandardToArray)
        {
          
            char temp;
            for (int i = 0; i < convertedStandardToArray.Length; i++)
            {
                for (int j = i + 1; j < convertedStandardToArray.Length; j++)
                {
                    var c1 = convertedStandardToArray[i];
                    var c2 = convertedStandardToArray[j];

                    if (Char.ToLower(c1) != Char.ToLower(c2))
                    {
                        if (convertedStandardToArray[i] < convertedStandardToArray[j])
                        {

                            temp = convertedStandardToArray[i];
                            convertedStandardToArray[i] = convertedStandardToArray[j];
                            convertedStandardToArray[j] = temp;
                        }
                    }
                    else
                    {
                        if (!char.IsUpper(c1))
                        {
                            temp = convertedStandardToArray[i];
                            convertedStandardToArray[i] = convertedStandardToArray[j];
                            convertedStandardToArray[j] = temp;
                        }

                    }

                }
            }

            return convertedStandardToArray;
        }

        public static bool IsValid(string str)
        {
            if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            else if (str.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //static void Main(string[] args)
        //{
        //    /*
        //    if (Int32.TryParse("-105", out int j))
        //        Console.WriteLine(j);
        //    else
        //        Console.WriteLine("String could not be parsed.");

        //    var str = "3";
        //    var num = Int32.Parse(str);
        //    */

        //    Console.WriteLine("Please input a value");
        //    var input = Console.ReadLine();

        //    if (IsValid(input))
        //    {
        //        Console.WriteLine($"{input}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Bad!");
        //    }
        //    Console.ReadLine();
        //}


    }
}
