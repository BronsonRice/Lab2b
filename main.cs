using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2;
    int diff = num1 - num2;
    int product = num1 * num2;
    int quotient = num1/ num2;
    int remainder = num1 % num2;

    Console.WriteLine("sum=" + sum);
    Console.WriteLine("diff=" + diff );
    Console.WriteLine("product="+ product);
    Console.WriteLine("quotient="+ quotient);
    Console.WriteLine("remainder="+ remainder);


    


    
    
  }
}