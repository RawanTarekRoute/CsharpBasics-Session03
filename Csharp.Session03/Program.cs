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
