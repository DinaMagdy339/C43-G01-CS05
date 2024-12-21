using System.Text;
using System.Xml;

namespace assign05
{
    internal class Program
    {
        #region Functions

        //// 1-
        //static void SwapByValue(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"Swap By Value: x = {x}, y = {y}");
        //}

        //static void SwapByReference(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"Swap By Reference: x = {x}, y = {y}");
        //}



        ////2-
        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null)
        //    {
        //        arr = new int[] { 10, 20, 30, 40 };
        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];
        //    }
        //    Console.WriteLine($"Sum By Value = {sum} : arr[0] = {arr[0]}");
        //    return sum;
        //}
        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null)
        //    {
        //        arr = new int[] { 10, 20, 30, 40 };
        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];
        //    }
        //    Console.WriteLine($"Sum By Reference = {sum} : arr[0] = {arr[0]}");
        //    return sum;
        //}


        //// 3-
        //public static void SumSub(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}


        ////4-
        //public static int SumIndividualDigits(int X)
        //{
        //    string Y = Convert.ToString(X);
        //    int sum = 0;
        //    for (int i = 0; i < Y.Length; i++)
        //    {
        //        sum += int.Parse(Y.Substring(i, 1));
        //    }
        //    return sum;
        //}

        //// 5-
        //public static bool IsPrime(int number)
        //{
        //    if (number == 2 || number == 3 || number == 5) return true;
        //    if (number <= 1) return false;
        //    if (number % 2 == 0) return false;
        //    if (number % 3 == 0) return false;
        //    if (number % 5 == 0) return false;
        //    return true;
        //}


        //// 6-
        //public static void SumSubArray(ref int[] arr , out int Max , out int Min)
        //{
        //    Max = arr[0]; Min = arr[0];
        //    if (arr is not null)
        //    {
        //        foreach (int value in arr)
        //        {
        //            if (value > Max) { Max = value;}
        //            if (value < Min) { Min = value;}
        //        }
        //    }
        //}

        //// 7-
        //public static long Factorial(int X)
        //{
        //    if (X < 0) { Console.WriteLine($"{X} :: can not factorial of this number"); }

        //    long FactorialNumber = 1 ;

        //    for (int i = 1; i <= FactorialNumber ; i++)
        //    {
        //        FactorialNumber *= i;
        //    }

        //    return FactorialNumber;
        //}

        //// 8-
        //public static String ChangeChar(String input, int position, char newChar)
        //{
            
        //    if (input is null && (position < 0 || position >= input.Length))
        //    {
        //        Console.WriteLine("You have error in your data");
        //    }
        //    StringBuilder sb = new StringBuilder(input);
        //    sb[position] = newChar;

        //    return sb.ToString();
        //}


        #endregion

        static void Main(string[] args)
        {

            #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            /* Passing by Value:
                 The ModifyByValue method gets a copy of value.
                 Modifications to number inside the method do not affect the original value in Main.
               Passing by Reference:
                 The ModifyByReference method gets a reference to value.
                 Modifications to number inside the method directly affect the original value in Main.  */

            //int a = 5, b = 10;

            //Console.WriteLine($"Before SwapByValue: a = {a}, b = {b}");
            //SwapByValue(a, b);
            //Console.WriteLine($"After SwapByValue: a = {a}, b = {b}");

            //Console.WriteLine($"Before SwapByReference: a = {a}, b = {b}");
            //SwapByReference(ref a, ref b);
            //Console.WriteLine($"After SwapByReference: a = {a}, b = {b}");

            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*Passing by Value:
            In ModifyArrayByValue, the arr[0] modification affects the original array because the reference to the array is passed by value, allowing changes to the contents of the array.
            When arr is reassigned to a new array, it does not affect the original array reference in the Main method.
            Passing by Reference:
            In ModifyArrayByReference, the arr[0] modification affects the original array, just like in the by-value case.
            When arr is reassigned to a new array, this change affects the original reference in the Main method, replacing the original array with the new one.*/


            //int[] numbers = { 1, 2, 3 };

            //Console.WriteLine($"Before Sum By Value Numbers[0] = {numbers[0]}");
            //int result = SumArray(numbers);
            //Console.WriteLine($"Sum =  {result}");
            //Console.WriteLine($"After Sum By Value Numbers[0] = {numbers[0]}");

            //Console.WriteLine($"Before Sum By Reference Numbers[0] = {numbers[0]}");
            //result = SumArray(ref numbers);
            //Console.WriteLine($"Sum =  {result}");
            //Console.WriteLine($"After Sum By Reference Numbers[0] = {numbers[0]}");

            #endregion

            #region 3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int a = 5 , b = 7 , Sum ,Sub ;
            //SumSub(a, b ,out Sum , out Sub );
            //Console.WriteLine($"Sum = {Sum}");
            //Console.WriteLine($"Sub = {Sub}");


            #endregion

            #region 4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //int SumColumn = SumIndividualDigits (num);
            //Console.WriteLine($"The sum of the digits of the number {num} is: {SumColumn}");

            #endregion

            #region  5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not.

            //Console.WriteLine("Enter an int num");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine(IsPrime(num));

            #endregion

            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] arr = { 1, 2, 3 , 900 , 101 };
            //int max , min;
            //SumSubArray(ref arr, out max, out min);
            //Console.WriteLine($"Max = {max}  ,  Min = {min}");

            #endregion

            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine(Factorial(num));
            #endregion

            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //Console.WriteLine("Enter string , position ,different letter ");
            //Console.Write("The word : ");
            //string input = Console.ReadLine() ?? "0";
            //Console.WriteLine("position : ");
            //int position =int.Parse( Console.ReadLine() ?? "0");
            //Console.WriteLine("different letter");
            //char newchar = char.Parse(Console.ReadLine() ?? "0");   
            //String Modify = ChangeChar(input,position,newchar);
            //Console.WriteLine($"modified word : {Modify} ");

            #endregion

        }
    }
}
