using System;
using System.Text;

namespace StringStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value,Referance - ref,out
            //int num1 = 5;
            //int num2 = num1; //num2=5
            //num2 = 10;
            //Console.WriteLine($"num1:{num1}");
            //Console.WriteLine($"num2:{num2}");

            //int[] arr = { 10, 20, 30 };
            //int[] arr3= { 10, 20, 30 };
            //int[] arr2 = arr;

            //arr2[0] = 100;

            //Console.WriteLine($"arr:{arr[0]}");
            //Console.WriteLine($"arr3:{arr3[0]}");
            //Console.WriteLine($"arr2:{arr2[0]}");
            //int a = 5;
            //Change(a);
            //Console.WriteLine($"a:{a}");
            //int[] arr = { 1, 2, 3 };
            //ChangeArr(arr);
            //Console.WriteLine($"arr:{arr[0]}");
            //int number=1;
            //ChangeRef(ref number);
            //Console.WriteLine($"number:{number}");
            #endregion

            #region String,StringBuilder,StringBuffer


            //string word = "Hello Bye Hi";
            //string word1 = "Hello";
            //string[] arr = word.Split("lo");
            //Console.WriteLine(arr[2]);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(word.LastIndexOf('h'));
            //string newStr=word.Remove(2,3);
            //Console.WriteLine(newStr);

            //Console.WriteLine(word.ToLower().Contains(word1.ToLower()));

            //Console.WriteLine(word1.ToLower());
            //string str = String.Empty;
            //Console.WriteLine(word.Trim().Length);
            //Console.WriteLine($"{word} {word1}");
            // Product  prod
            //Console.WriteLine(String.Compare(word,0,word1,0,5));
            //word1 = word1 + " World";
            //Console.WriteLine(word1[0]);
            //string word2 = word1;
            //word2 = "Bye";
            //string word3 = "Bye";
            //word3 = "Hi";
            //string sentence = "Salam Ehed bey";
            //String word4 = new String("Bye");
            //Console.WriteLine($"word1:{word1}");
            //Console.WriteLine($"word2:{word2}");
            //Console.WriteLine(CustomReverse(word1));
            #endregion

            #region Array
            int[] arr = { 5,3,1,4,0 };

            Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Resize(ref arr, arr.Length + 1);
            //arr[3] = 4;
            //Console.WriteLine(arr.Length);
            //int[] arr1 = new int[3] { 2, 3,4 };
            #endregion

        }

        #region String,StringBuilder,StringBuffer
        static StringBuilder CustomReverse(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result.Append(str[i]);
            }

            return result;

            //string result = String.Empty;

            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    result += str[i];
            //}

            //return result;
        }
        #endregion

        #region Value,Referance - ref,out
        //static void ChangeRef(ref int n)
        //{
        //    Console.WriteLine($"method:{n}");
        //}


        //public static void ChangeArr(int[] p)
        //{
        //    p[0] = 10;
        //    Console.WriteLine($"p:{p[0]}");
        //}

        //public static void Change(int p)
        //{
        //    p = 10;
        //    Console.WriteLine($"p:{p}");
        //}
        #endregion
    }
}
