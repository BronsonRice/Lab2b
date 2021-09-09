using System;

class Program {
  public static void Main (string[] args) {
    /* Declaring variables */
    int num1 = 15;
    int num2 = 8;
    int sum= 23;
    int diff = 7;
    int product = 120;
    int quotient = 1;
    int remainder = 7;


    /* Output statements */
    Console.WriteLine("Enter a number:" + num1);
    Console.WriteLine("Enter another number:" + num2);
    Console.WriteLine("sum=" + sum);
    Console.WriteLine("diff=" + diff);
    Console.WriteLine("product=" + product);
    Console.WriteLine("quotient=" + quotient);
    Console.WriteLine("remainder=" + remainder);

    /* Arithmetic operators */
    sum = 15 + 8;
    diff = 15 - 8;
    product = 23 * 7;
    quotient = 15/8;
    remainder = 15 % 8;

  }
}