/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP-003A
 * Purpose: Lecture activity for varibles type system, Math, and Console properties 
 * Reference: The #C Player's Guide (4e) by RB Whitaker 
 */

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* working with varibles */
            // the following code shows all three primary variable-related activities:
            string username; //declaring a varible (1 of 3)
            Console.WriteLine("What is your name"); // request for user input
            username = Console.ReadLine(); //assigning a value to a varible (2 of 3)
            Console.WriteLine("Hi  " + username); //retrieving its current value (3 of 3)


            // another example of the three primary varible related activities (declaring, assigning. and retrieving)
            string favortieColor;
            Console.WriteLine("What is your favorite color");
            favortieColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favortieColor);


            /* working with variables integers */
            int score; // declare a new varible with a data type int
            // score = "Generic User"; // will fail to compile because you are assigning a string value to an integer variable 
            // score = "0"; // will still fail to compile because the "0" is still assigned as a string - enclosed in the double quotes
            score = 0; //works 
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;


            /* reading from a variable does not change it */
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The new value of a: " + a);
            Console.WriteLine("The new value of b: " + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a: " + a);
            Console.WriteLine("The new value of b: " + b);

            /* variable are case-sensitive */
            // the variables below are different despite having similar names 
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("******************************");
            /*
             * types of variables and values matter in C#. they are not interchangeable.
             * there are eight integer types for storing integers of differing sizes and ranges: int, short, long, sbyte, uint, ushort, and ulong.
             * the char type stores single characters.
             * the string type type stores longer text.
             * there are three types for storing real numbers: float, double, and decimal.
             * the bool type stores truth values (true and false) used in logic.
             * these types are the building blocks of a much larger type of system.
             * using var for variable's type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (But it still has a specific type.)
             * the System.Convert class is a useful class to convert from one type to another.
             */

            /* declaring and using variables with integer text */
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short Anumber = 5039;
            Console.WriteLine("aNumber: " + Anumber);
            Anumber = -4354;
            Console.WriteLine("aNumber: " + Anumber);

            long aVeryBigNumber = 395904282569;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

            int anInteger = 2147483647;
            
            /* declaring, using, and concatenating characters ans strings */
            char aLetter = 'A'; // character values are enclosed in singe quotes
            string message = "Hello World"; // string values enclosed in double quotes 

            Console.WriteLine("Concatenating using + ;" + aLetter + " " + message); // use the plus (+) sign in between characters/strings to concatenate 
            Console.WriteLine($"Concatenation using string interpolation : {aLetter} {message} "); // use string interpolation with a dollar-sign ($) before the opening double-quotes and enclosing variables with curly braces ({variableName})

            /* floating-point types */
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Value of number3: {number3}");

            /* scientific notation */
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");

            /* bool type */
            bool itWorked = true; 
            Console.WriteLine($"New value of itWorked: {itWorked}");
            itWorked = false;
            Console.WriteLine($"New value of itWorked: {itWorked}");

            /* convert */
            string inputAgeString;
            int inputAge;
            int currentYear = 2023;

            Console.WriteLine($"Enter age in in {currentYear}: ");
            inputAgeString= Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is {inputAge}");

            Console.WriteLine("*****************************");
            /*
             * math operations
             * addition: +
             * subtraction: - 
             * multiplication: *
             * divison: /
             * modulo: % (remainder)
             */
            int addition = 2 + 3;
            int subtraction = 5 - 2;
            int multiplication = 22 * 2;
            int divison = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of divison: {divison}");
            Console.WriteLine($"value of modulo: {modulo}");

            /*
             * arithmetic, compound expressions and order of operations
             * Multiplications and divison are done first, left to right
             * Addition and subtraction are done last, left to right
             * Reference: https://csharpplayersguide.com/article/operators-table
             */

            int arithmetic1; // declaring the varible arthimetic1.
            arithmetic1 = 9 - 2; // assigning a value to arithmetic1, using some math.
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3; // another assignment.
            Console.WriteLine($"New value of arithemtic1: {arithmetic1}");
            int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a value to arithmetic2 all at once.
            Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2; //assigning a second value to arithmetic2.
            Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

            // use multiple sets of parentheses to group operations
            int results = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result: {results}");

            /* compound assignment operator */
            int compoundAssignmentOperator = 0;
            compoundAssignmentOperator += 5; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator + 5; (a is 5 after this line runs.)
            compoundAssignmentOperator -= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator - 2; (a is 3 after this line runs.)
            compoundAssignmentOperator *= 4; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator * 4; (a is 12 after this line runs.)
            compoundAssignmentOperator /= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator / 2; (a is 6 after this line runs.)
            compoundAssignmentOperator %= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator % 2; (a is 0 after this line runs.)

            /* increment and decrement operators */ 
            int incrementDecrementOperators = 0;
            incrementDecrementOperators++; // The equivalent of incrementDecrementOperators += 1; or incrementDecrementOperators += 1; or incrementDecrementOperators + 1;
            incrementDecrementOperators--; // The equivalent of incrementDecrementOperators -= 1; or incrementDecrementOperators -= 1; or incrementDecrementOperators - 1;

            Console.WriteLine("*************************************");
            /* console 2.0 */
            Console.WriteLine("What is your name, human? "); // notice the space at the end. 
            string userName = Console.ReadLine(); // reads the entire line
            // results: What is your name, human? jonathan

            Console.WriteLine("Press any key when you're ready to begin.");
            Console.ReadKey(); // reads a keystroke

            Console.BackgroundColor = ConsoleColor.Yellow; // changes the console background to yellow 
            Console.ForegroundColor = ConsoleColor.Black; // change the console text to black 
            Console.Title = "Hello World!"; // changes the console title 

            Console.Beep(440, 1000); // computer beeps

        }
    }
}