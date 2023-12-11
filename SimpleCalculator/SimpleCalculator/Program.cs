// See https://aka.ms/new-console-template for more information
using System;
class SimpleCalculator{
    static void Main(){
        int res =0;
        Console.WriteLine("Enter the expressio:");
        int a = Convert.ToInt32(Console.ReadLine());
        string op = Console.ReadLine();
        int b = Convert.ToInt32(Console.ReadLine());

        switch (op){
            case "+": res = a + b; break;
            case "-": res = a - b; break;
            case "*": res = a * b; break;
            case "/": 
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by 0...");
                    
                }
                else
                {
                    res = a / b; break;
                } break;
            case "%":
                if (b != 0)
                {
                    res = a % b; break;
                }
                else
                {
                    Console.WriteLine("Cannot divide by 0...");
                }break;
            default: Console.WriteLine("invalid expression..");break;
        }
        Console.WriteLine("result: " + res);
    }
}

