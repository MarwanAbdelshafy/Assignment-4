using System.Buffers.Text;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Assignment_4
{
    internal class Program
    {
        public static void swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        public static int SumArray(ref int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }

        public static void SumSub(int c, int m, int y, int k, out int Sum, out int Sub)
        {
            Sum = c + m;
            Sub = y - k;

        }

        static int SumOfIndv(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int dig = num % 10;
                sum += dig;
                num /= 10;
            }

            return sum;
        }


        public static bool prime(int number)
        {
            if (number == 1)
                return false;

            for (int i = 2; i < number; i++)

                if (number % i == 0)
                    return false;
            return true;
        }
        public static void MinMaxArray(ref int[] Arr , ref int max , ref int min)
        {
            max = Arr[0]; min = Arr[0];
           
            for (int i = 0; i < Arr.Length; i++)
            {
                if(max < Arr[i])
                max = Arr[i];
                if (min > Arr[i]) 
                min = Arr[i];
            }
        }


        static int factorial(int num)
        {
            int factorial = 1;


            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }



            return factorial;
        }

        public static string ChangeChar(string word, int c, char change)
            {
            word = word.Remove(c-1 ,1);
            word = word.Insert(c-1, change.ToString());

            return word;
            }


        static void Main(string[] args)
        {
            #region assignment


            #region Q1
            //Explain the difference between passing(Value type parameters)
            //by value and by reference then write a suitable c# example

            //passing by value 

            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a); 
            //Console.WriteLine(b);

            //swap(a, b);
            //Console.WriteLine(a);   
            //Console.WriteLine(b);

            //swap done in swap stak frame and deleted after run 'no swap'

            //swap by ref

            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //swap done in main stak frame and swap number in this case becasue it handel whit refernces


            #endregion

            #region @2
            //Explain the difference between passing(Reference type parameters) 
            //by value and by reference then write a suitable c# example

            //passing by value  
            //int[] numbers = { 1, 2, 3};
            //Console.WriteLine(SumArray( ref numbers));

            //when edit in array or numbers both of them point at same adderss
            //so i can edit in anyone
            //both of them see same opject

            //passing by ref
            //change name of numbers to arr in stake and stay refrecne to same object 

            #endregion

            #region Q3
            //Write a c# Function that accept 4 parameters from user and return
            //result of summation and subtracting of two numbers

            //int a = 10;
            //int b = 20;
            //int c = 30;
            //int d = 40;
            //int Sum , Sub ;

            //    SumSub(a,b,c,d, out Sum  , out Sub);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Sub);



            #endregion

            #region Q4
            //Write a program in C# Sharp to create a function to calculate
            //the sum of the individual digits of a given number


            //bool flag;
            //int number;

            //do
            //{
            //    Console.WriteLine("enter number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag);

            //int result = SumOfIndv(number);
            //Console.WriteLine($"The sum of the digits of the number {number} is: {result}");

            #endregion

            #region Q5
            //Create a function named "IsPrime", which receives an integer number
            //and retuns true if it is prime, or false if it is not


            //bool flag;
            //int number;

            //do
            //{
            //    Console.WriteLine("enter number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag);

            //Console.WriteLine(prime(number));

            #endregion

            #region Q6
            //Create a function named MinMaxArray, to return the minimum and maximum values
            //stored in an array, using reference parameters



            //int[] numbers = { 10,20,30,40,50 };

            //int min = 0, max = 0;

            //MinMaxArray(ref numbers,ref max , ref min);

            //  Console.WriteLine($"maximum value: {max}");
            //  Console.WriteLine($"minimum value: {min}");



            #endregion

            #region Q7

            //Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter



            //bool flag;
            //int number;

            //do
            //{
            //    Console.WriteLine("enter number to get factorial : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!flag);

            //int result =factorial(number);


            //Console.WriteLine($"factorial of {number} is {result}");
            #endregion

            #region Q8

            //Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string,
            //replacing it with a different letter


            //Console.Write("Enter a Word : ");
            //string word = Console.ReadLine();

            //Console.Write("Enter number of char you would to change: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.Write("Enter new char : ");
            //char change = char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //string result = ChangeChar(word, c, change);

            //Console.WriteLine(result); 
            #endregion
            #endregion

            #region Demo

            #region Casting 
            // Reference Type Casting => Convert from Reference to To Reference Type
            // Boxing Casting => Convert from Value Type to To Reference Type
            // UnBoxing Casting => Convert from  Reference Type to Value Type

            #region Boxing
            //object obj = new object();
            //obj = "marwan"; // Reference Type Casting
            //obj = 2; // Boxing [Casting from Value Type [int] to Reference Type [Object]]



            //int X = 10;
            //object obj01 = new object();
            //obj01 = X;  //stac -->heap (boxing)


            // Parent = Child
            // Dog is Animal
            #endregion

            #region unboxing

            //object obj02 = new object();
            //obj02 + 10;
            //int X = (int)obj02;


            // Child = Parent
            // Animals are Dogs

            #endregion

            #endregion

            #region Nullable Datatype

            #region value type

            //int X = null; // int Number only

            //int? X = null; // int Number and Null

            //Nullable<int> Number;

            //Console.WriteLine(X};

            //int X = 2;
            // int Y = 3;


            //int X = 10;
            //int? Y = /*(int?)*/X;

            //int? X = null;
            //int Y;
            //if (X != null)
            //{
            //Y = (int)X; // Casting
            //}
            //else
            //{
            //Y = 0;
            //}




            //if (X.HasValue)
            //{
            //Y = X.Value;
            //}
            //else
            //{
            //Y = 0;
            //}



            //Y = X.HasValue ? X.Value : 0;
            //Console.WriteLine(Y);

            #endregion


            #region Null Propagation Operator
            //int[] Numbers = null;

            /////////// for (int i = 0; Numbers!=null && i < Numbers.Length; i++)
            ////for (int i = 0; i < Numbers ?.Length; i++)
            //{
            //Console.WriteLine(Numbers[i]);

            //}



            // i < Numbers ?. Length
            // Numbers => Object [Length]
            //Numbers => Null[Null]



            //int[] Numbers = null;
            //if (Numbers != null)
            //{
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Console.WriteLine(Numbers[i]);
            //}
            //}







            //int Length = Numbers ?. Length ?? 0;

            //Console. WriteLine(Length);







            //Employee Emp = new Employee();

            //Console.WriteLine(Emp.Department.Name);



            //if (Emp != null)
            //{
            //if (Emp.Department != null)
            //{
            //Console.WriteLine(Emp.Department.Name);
            //}
            //}


            //Console.WriteLine(Emp.Department?.Name ?? "Not Found");
            #endregion

            #endregion

            #region Functions

            // Types of Function
            // 1. Class Member Function [static Function]
            // 2. object Member Function [non Static Function]


            // 1-static Function

            //public static void PrintShape()
            //{
            //for (int i = 0; i < 10; i++)
            //{
            //Console.WriteLine("( *-* )");
            //}
            //}


            //PrintShape()




            #endregion

            #region  Value Type Paramters





            //public static void Swap(int X, int Y)
            //{
            //int Temp = X;
            //X = Y;
            //Y = Temp;
            //}

            #region by value
            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            //Swap(A, B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #region By ref
            //public static void Swap(ref int X, ref int Y)
            //{
            //int Temp = X;
            //X = Y;
            //Y = Temp;
            //}




            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            //Swap(ref A,ref  B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);





            #endregion


            #endregion

            #region refrence type

            //public static int SumArray(int[] Arr)
            //{
            //// Sum + 1 = 1
            ////1+2=3
            ////3+3=6
            //int Sum = 0;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;

            //}
            //



            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbärs));


            #region Ex01

            #region By Value

            //public static int SumArray(int[] Arr)
            //{
            //// Sum + 1 = 1
            ////1+2=3
            ////3+3=6
            //int Sum = 0;
            //arr[0]=100;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;

            //}
            //



            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region by Ref





            //public static int SumArray(ref int[] Arr)
            //{
            //// Sum + 1 = 1
            ////1+2=3
            ////3+3=6
            //int Sum = 0;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;

            //}
            //




            //int[] Numbers = { 1,*2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);





            #endregion

            #endregion

            #region Ex02


            //public static int SumArray(int[] Arr)
            //{
            //// Sum +1=1
            ////1 + 2 =3
            //// 3 + 3 = 6
            //int Sum = 0;
            ////Arr[0]=100;
            //Arr = new int[] { 4, 5, 6 };
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;
            //}




            #region  by value 


            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(NumbErs[0]);


            #endregion


            #region by ref

            //    public static int SumArray(ref int[] Arr)
            //{
            //    // Sum + 1=1
            //    //1+2=3
            //    // 3 +3 =6
            //    int Sum = 0;
            //    //Arr[0] = 100+
            //    Arr = new int[] { 4, 5, 6 };
            //    for (int i = 0; i < Arr.Length; i++)
            //    { 
            //        Sum += Arr[i];
            //}
            //    return Sum;

            //}  



            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]); 


            #endregion
            #endregion


            #endregion

            #region Functions - Passing By Out


            //public static void SumMul(int X, int Y, out int Sum, out int Mul)
            //{
            //Sum = X + Y;
            //Mul = X * Y;
            //return Sum;
            //return Mul;
            // }





            //int A = 10;
            //int B = 20;
            //int Sum, Mul;
            //SumMul(A, B, out Sum, out Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);
            #endregion

            #region Functions - Params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SumArray(Numbers));

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } ;
            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8,9,10));


            //int A = 10, B = 20, C = 30;
            //Console.WriteLine("A : {0} , B : {1} ,C : {2}" , A, B, C);
            #endregion

            #endregion

        }
    }
}

