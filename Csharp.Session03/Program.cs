namespace Csharp.Session03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Exceptions

            /*
             * An object that have information about an error that has occurred.
             * To handle exceptions, we use try-catch-finally block.
             * 
             * Try => try to execute the code that may throw an exception.
             * Catch => hold the exception and do something with it without crashing the program.
             *      You can: Display a message to the user, 
             *      Log the exception, 
             *      Retry the operation,
             *      Throw a new exception to be handled by a higher-level catch block.
             *      
             * Finally => always execute the code in the finally block, regardless of whether an exception was thrown or not.
             * For one try, you can have many catch blocks (FileNotFoundException, UnauthorizedAccessException, ...)
             * You have Exception class in C# which is the base class for all exceptions. YOU should use it as a last catch block to catch any exception that is not handled by the previous catch blocks.
             * If you assuming to have N exceptions, you should have N+1 catch blocks, the last one is for Exception class (the general exception).
             * 
             */

            //try
            //{
            //    File.ReadAllText("Rawan.txt");
            //    Console.WriteLine("File read successfully."); 
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    // file not found => try to open another file

            //}
            //catch (UnauthorizedAccessException ex )
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //finally
            //{
            //    // Close connection with db
            //    // Close some files.
            //    Console.WriteLine("Finally block executed."); 
            //}


            // functionA called functionB
            // functionB is not responsible for handling the exception, read some data from a file.
            // functionB rethrow the exception => functionA is responsible for handling the exception.


            //try
            //{
            //    functionA();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero.");
            //}




            #endregion

            #region Implicit - Explicit Casting

            /* Data Type Sizes in C#:
             * byte => 1 byte
             * short => 2 bytes
             * int => 4 bytes
             * sint => 4 bytes
             * long => 8 bytes
             * slong => 8 bytes
             * 
             * float => 4 bytes
             * double => 8 bytes
             * decimal => 16 bytes
             * 
             * bool => 1 byte
             * char => 2 bytes
             * string => 2 bytes per character
             * 
             * To know the maximum and minimum values of a data type, you can use the following properties:
             * [type].MaxValue and [type].MinValue => int.MaxValue, int.MinValue and so on.
             */
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            //Console.WriteLine(long.MaxValue);

            //int? nullableValue = 100; // int?

            // 1. Garbage Value 
            // 2. Exception
            // 3. Empty String
            // null.Value

            //if (nullableValue.HasValue == true)
            //{
            //    Console.WriteLine(nullableValue.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Value can not be null");
            //}

            //bool result = nullableValue.HasValue ? true : false;

            //if (result == true)
            //{
            //    Console.WriteLine(nullableValue.Value);
            //}






            #region Implicit Casting

            // 2 liter of water => bottle can hold 5 liter of water
            // short 2 byte => int 4byte
            // value of smaller ==> variable of larger data type

            //int score = 50;
            //double doubleScore = score; 
            //Console.WriteLine($"score: {score}, doubleScore: {doubleScore}");

            //int x = int.MaxValue;
            // int + int => int
            // int + long => long
            // long + int => long

            // short + int => int
            //long longX = x + 1;
            //Console.WriteLine(longX);


            //long number01 = 10;
            //int number02 = (int) number01;



            #endregion

            #region Explicit Casting

            // 8 byte
            //double percentage = 99.9;

            //int percentageInt = (int) percentage;
            //Console.WriteLine(percentageInt);

            //float percentageFloat = (float)percentage;
            //Console.WriteLine(percentageFloat);

            //long longVar = 1000;
            //// value < int.MaxValue && value > int.MinValue
            //// 1 - 5

            //if (longVar > int.MaxValue || longVar < int.MinValue)
            //{
            //    Console.WriteLine("Overflow or underflow will happen ");
            //}
            //else
            //{
            //    int intVar = (int) longVar;
            //    Console.WriteLine("Casting Succeeded");
            //    Console.WriteLine(intVar);
            //}



            #endregion

            #region Important Notes on floating-point and integer types with casting

            //// float => 4 byte
            //// int => 4 byte

            ////float floatVariable = 50;
            ////int intVar02 = floatVariable;

            //int intVar02 = 100;
            //float floatVar = intVar02;
            //Console.WriteLine(floatVar);



            #endregion


            #endregion

            #region Convert Class

            //Console.WriteLine("Enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine(name);


            // 1. Convert class with null => Default value based on the target data type
            // 2. Convert class with invalid format => FormatException


            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);
            //Console.WriteLine(age.GetType());

            //string ageString = "25";
            //age = (int) ageString;


            //Console.WriteLine("Enter your salary");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(salary);
            //Console.WriteLine(salary.GetType());



            #endregion

            #region Parse & Try Parse

            // parse with nulls => ArgumentNullException
            // parse with invalid format => FormatException

            //Console.WriteLine("Enter your age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);
            //Console.WriteLine(age.GetType());


            //Console.WriteLine("Enter your age:");
            //int age;
            //// source value    ==> Target value with target data type
            //bool isParsed = int.TryParse("50", out age);
            //Console.WriteLine(isParsed);
            //Console.WriteLine(age);
            //Console.WriteLine(age.GetType());





            #endregion

            #region ToString()

            //decimal salary = 1000000;
            //Console.WriteLine(salary.ToString("N0"));
            //Console.WriteLine(salary.ToString("C0"));

            //float percentage = 0.51f;
            //Console.WriteLine(percentage.ToString("P0"));

            //Console.WriteLine(percentage.ToString("F1"));


            #endregion

            #region Boxing & Unboxing

            //int number = 100;
            //object obj = number;

            //int newNumber = (int) obj;
            //Console.WriteLine(newNumber);


            #endregion

            #region Control Statements

            #region Conditional Statements

            /*
             * Operators:
             * Logical Operators: 
             * Short Circuit means CLR will stop checking the next condition 
             * once the final result is determined => making the code more efficient.
             * Short-circuiting operators: &&, ||
             * 
             * && => Logical AND
             *       Both conditions must be true.
             *       true && true => true
             *       true && false => false
             *       false && true => false
             *       
             *       
             * || => Logical OR
             *      At least one condition must be true.
             *      true || true => true
             *      true || false => true
             *      false || true => true
             *      false || false => false
             *      
             *      
             *  ! => Logical NOT
             *       Reverses the value of a boolean expression.
             *       !true => false
             *       !false => true
             *       
             * Bitwise Operators:
             * & => Bitwise AND
             *      compares each bit of two operands and returns 1 if both bits are 1, otherwise returns 0.
             *      With boolean values, it behaves like logical AND but without short-circuiting.
             *      
             *      7(true) && 2 (true) => true;
             *      7 & 2 =>
             *      
             *               7 => 0111
             *               2 => 0010 
             *            Result: 0010 => 2
             *            
             * | => Bitwise OR
             *      compares each bit of two operands and returns 1 if at least one of the bits is 1, otherwise returns 0.
             *      with boolean values, it behaves like logical OR but without short-circuiting.
             *      
             *      7 || 2 =>
             *      7 | 2 =>
             *          
             *              7 => 0111
             *              2 => 0010
             *          Result:  0111 => 7
             */

            #region If Condition

            #region Example 01

            //Console.WriteLine("Enter the score:");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 90)
            //    Console.WriteLine("Your Grade is A");
            //else if (score >= 80)
            //    Console.WriteLine("Your grade is B");
            //else if (score >= 60)
            //    Console.WriteLine("Your grade is C");
            //else if (score >= 50)
            //    Console.WriteLine("Your grade is D");
            //else
            //    Console.WriteLine("Your grade is F");










            #endregion

            #region Example 02, AND
            // Student and age < 10 => no fees to pay
            // Student and age >= 10 => have discount 50%
            // Anyone else => have to pay full fees


            //string status = "student";
            //int age = 10;

            //if (status == "student")
            //{
            //    if (age < 10)
            //        Console.WriteLine("No fees");
            //    else
            //        Console.WriteLine("50% Discount");
            //}
            //else
            //    Console.WriteLine("full fees");





            #endregion

            #region Example 03, OR

            // Building Invitation
            // Has invitation or knows the host => can enter the building
            // else => cannot enter the building

            //bool hasInvitation = false;
            //bool knowHost = true;

            //if (hasInvitation || knowHost)
            //    Console.WriteLine("You can enter the building");
            //else
            //    Console.WriteLine("You can not enter the building");





            #endregion


            #endregion

            #region Switch

            #region Switch With int

            // Jump Table

            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            /*
             * Does Every switch always use a jump table? =
             * Answer: No not always, It dependes on what your are switching on
             * 
             * Switch Type                                                      Implementation
             * ----------------------------------------------------------------------------------
             * int or enum values                                               |  Jump Table
             * strings (C# 7.0 and later)                                       |  Hash based table
             * Pattern matching (<, >, types)                                   |  If-Else Chain
             * number of cases is small (less than 3)                           |  If-Else Chain
             * The C# compiler decides the best implementation based on the switch expression and the case labels.
             */


            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("You entered 1.");
            //        break;
            //    case 2:
            //        Console.WriteLine("You entered 2.");
            //        break;
            //    case 4:
            //        Console.WriteLine("You entered 4.");
            //        break;
            //    case 100:
            //        Console.WriteLine("You entered 100.");
            //        break;
            //    case 200:
            //        Console.WriteLine("You entered 200.");
            //        break;
            //    case 150:
            //        Console.WriteLine("You entered 150.");
            //        break;
            //    default:
            //        Console.WriteLine("You entered a number other than 1, 2, or 3.");
            //        break;
            //}

            #endregion

            #region Switch With String

            //string role = Console.ReadLine();
            //string access;

            //switch (role)
            //{
            //    case "Admin":
            //        Console.WriteLine("You have full access.");
            //        break;
            //    // No duplicate case labels are allowed in a switch statement. 
            //    // Compiler uses Equals() and GetHashCode() methods to check for duplicate case labels.
            //    //case "Admin":
            //    //    Console.WriteLine("You have full access.");
            //    //    break;
            //    case "Manager":
            //        Console.WriteLine("You have limited access.");
            //        break;
            //    case "User":
            //        Console.WriteLine("You have basic access.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid role.");
            //        break;
            //}

            #endregion

            #region Switch with type pattern + case guard (when clause)

            //object grade = 90.5f;

            //// From C# 7.0, you can use pattern matching.
            //// We can store value in temporary variable and use it in the case guard (when clause).

            //switch (grade)
            //{
            //    case int g when g >= 90:
            //        Console.WriteLine($"Grade is an integer: {g}");
            //        Console.WriteLine("Excellent!");
            //        break;
            //    case float g when g >= 85 :
            //        Console.WriteLine($"Grade is a float: {g}");
            //        Console.WriteLine("Very Good!");
            //        break;
            //    case double g when g >= 50:
            //        Console.WriteLine($"Grade is a double: {g}");
            //        Console.WriteLine("Good!");
            //        break;
            //    default: 
            //        Console.WriteLine("Grade is not a valid number.");
            //        break;

            //}

            #endregion

            #region Switch Expression

            // Syntax sugar introduced in C# 8.0
            // Used when you want to return a value based on a condition.
            // If you want to perform instructions based on a condition, use switch statement.

            //char grade = 'A';

            //string result = grade switch
            //{
            //    'A' => "Excellent!",
            //    'B' => "Very Good!",
            //    'C' => "Good!",
            //    'D' => "Pass",
            //    'F' => "Fail",
            //    _ => "Invalid grade"
            //};

            //Console.WriteLine(result);

            #endregion

            #endregion

            #region Ternary Operator

            // Conditional operator, short form of if-else statement, introduced in C# 2.0
            // used for simple conditional expressions that return a value based on a condition.
            // Syntax: condition ? value_if_true : value_if_false;
            // if you have more than two cases, if-else statement is more readable than ternary operator.

            //int cardsNumber = 100;
            //string result = cardsNumber > 50 ? "You have more than 50 cards." : "You have 50 or less cards.";
            //Console.WriteLine(result);

            #endregion




            #endregion

            #endregion

            #region Loops
            /*
             * Code to be executed multiple times without repeating the code
             * From performance perspective, repeating the code is more effecient (less steps)
             * From maintainability perspective, loops are more effecient (easy to fix and refactor) and it is easy for extension
             * We have 4 types of loops in C#:
             *  1. for loop: used when we know the number of iterations in advance
             *  2. while loop: used when we need the code to be executed as long as a condition is true
             *  3. do-while loop: used when we want to execute the loop body at least once, then it works like a while loop
             *  4. foreach loop: used to iterate over a collection - Will be used heavilty with C# Collections
             */

            // 

            // How many steps you wrote to print from 1 to 10? 10 steps
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            // How many steps you wrote to print from 1 to 10? 
            // * in first iteration
            //      1. int i = 1; // initialization
            //      2. i <= 10; // condition
            //      3. Console.WriteLine(i); // code to be executed
            //      4. i++; // increment
            //
            // * in remaining iterations
            //      1. i <= 10; // condition
            //      2. Console.WriteLine(i); // code to be executed
            //      3. i++; // increment
            // 
            // * last check when i = 11, the condition fails and the loop ends
            // Total steps = 4 + (3 * 9) + 1 = 32 steps
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region  For Loop Examples

            // Loop through an array of numbers and print each number
            // Try static number first then mak it numbers.Length

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine(numbers[index]);
            //}

            //// Multiplication table for 1 to 3
            //for (int row = 1; row <= 3; row++)
            //{
            //    for (int col = 1; col <= 3; col++)
            //    {
            //        Console.WriteLine($"{row * col}\\t");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Foreach

            /** Foreach loop is used to iterate over a collection, such as an array or a list.
             * It is more readable than a for loop, because it automatically handles the index and the length of the collection.
             * It will call GetEnumerator() that returns an anumerator that property [Current] and method [MoveNext()] to iterate over the collection.
             * For each iteration, it calls:
             *      - 1. Curent Propertyto get the current element
             *      - 2. MoveNext() to move to the next element
             * 
             * - Pitfalls:
             *      - 1. Performance: Foreach loop is slower than a for loop, because it has to make function calls in each iteration
             *      - 2. Read-only: Foreach loop does not allow modifying the collection, as you have a copy of the array element not the actual element in the collection.
             *      - 3. Index: Foreach loop does not provide access to the index of the current element.
             */

            //int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //foreach (int number in numbers)
            //{
            //    //number++; // Error: Cannot modify the iteration variable 'number' because it is a foreach iteration variable
            //    Console.WriteLine(number);
            //}



            #endregion

            #region While 

            /*
             * While loop is used to execute a block of code as long as a condition is true.
             * It is more flexible than a for loop, because it does not require an initialization or an increment.
             * It is useful when we do not know the number of iterations in advance.
             * 
             */

            // Example: Repeat asking the user to enter a number until the user enters a valid number.

            //int number;
            //Console.WriteLine("Enter a number: ");

            //bool isParsed = int.TryParse(Console.ReadLine(), out number);

            //while (!isParsed)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out number);
            //}

            //Console.WriteLine(number);



            #endregion

            #region Do-While

            /*
             * Do-While loop is used to execute a block of code at least once, and then repeat the execution as long as a condition is true.
             * It is useful when we want to execute the loop body at least once, regardless of the condition.
             * 
             */

            // Example: Repeat asking the user to enter a number until the user enters a valid number.

            //int number;
            //bool isParsed;

            //do
            //{
            //    Console.WriteLine("Enter a number: ");
            //    isParsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!isParsed);

            //Console.WriteLine(number);



            #endregion

            #endregion


        }

        //public static void functionA()
        //{
        //    try
        //    {
        //        int number01 = 1, number02 = 0;
        //        int result = number01 / number02;
        //    }
        //    catch(DivideByZeroException ex)
        //    {
        //        throw;
        //    }
        //}

    }
}
