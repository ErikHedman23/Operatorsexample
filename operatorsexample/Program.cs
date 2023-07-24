using System.Reflection.PortableExecutable;

namespace operatorsexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators
            int x = 5;
            int y = 5;
            int num1 = 3;
            int num2 = 4;
            num1 += num2; //equivalent to num1 = num1 + num2
            num1 -= num2;
            num1 *= num2;
            num1 /= num2;
            //"=" is an assignment operator
            int additionResults = 5 + 10;
            int subtractionResults = 10 - 9;
            int multiplicationResult = 10 * 10;
            int divisionResult = x / y;
            int modulusResult = x % y;
            //modulus gives you the remainder after division

            //bool evenOrOdd = 3 % 2 == 0;  //comparison operator

            //Console.WriteLine(evenOrOdd);
            //using a boolean will help you determine if a number is even or odd

            //Unary Operators

            int a = 3;
            int b = ++a;//pre increment bumps up the value first off so both a nd b will = 4

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 3;
            int d = c++;
            Console.WriteLine(c);
            Console.WriteLine(d);//post increment; this will cause c to = 4, but b will still = 3 because the code has gotten to the post increment ++ yet to alter d = c++, but it will affect c.
            //pre and post increments permenantly change the value of, say, x = __, in the code
            //pre and post decrements (--x; x--) work the same way same way as pre and post increments
            //Console.WriteLine(c--); Console.WriteLine(--c)

            //Relational Operators - checking to see if two different things are related to each other
            int e = 5;
            int f = 3;

            bool isEqual = e == f; //not the same == false

            bool notEqual = e != f; //not the same == true

            bool greaterThan = e > f; //checks if e is > f

            bool lessThan = e < f; //checks if e is < f

            bool greaterThanOrEqual = e >= f; //checks if e is greater than or equal to f

            bool lessThanOrEqual = e <= f; // 

            Console.WriteLine(!isEqual); //gives the opposite value 

            //Logical Operators
            bool result_1 = a == 5 && b < 5; //checks if both conditions are true; && == "and"; both values have to be true to be true

            bool result_2 = b < 10 || c > 20; //checks if either condition is true; || == "or"; either value has to be true for the boolean to be true

            //Null Coalecing Operator

            int? possiblyNullValue = null;
            int notNullNum = possiblyNullValue ?? 500; //?? checks to see if variable is null and if it is; then, it will assign the 500 given value to the variable

            Console.WriteLine(possiblyNullValue);

            //Null Conditional Operator
            string name = null;
            int nameLength = name?.Length ?? 0;












        }
    }
}