using System;
using CalculatorForDLL; // reference to the DLL namespace


    
        // Create an instance of the math class from the DLL
        MathOperations mathop = new MathOperations();

        // Perform addition using the math class
        int result = mathop.Add(5, 3);
        int result2 = mathop.Subtract(5, 3);
        int result3 = mathop.Multiply(5, 3);

        double result4 = mathop.Divide(5, 3); // double because divide returns a double
       // double result5 = mathop.Divide(0, 3); // Any exceptions?


// Display the result
Console.WriteLine("5 + 3 = " + result);
Console.WriteLine("5 - 3 = " + result2);
Console.WriteLine("5 * 3 = " + result3);
Console.WriteLine("5 / 3 = " + result4);
//Console.WriteLine("0 / 3 = " + result5);


    
