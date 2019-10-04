using System;

namespace Functions
{
    class Program
    {
   

    static void Main(string[] args)
    {
		char choice='z';
		float num1,num2;
		Console.WriteLine();
   	    Console.WriteLine("|========CALCULATOR========|");
		Console.WriteLine();
		Console.WriteLine(" A -----------------ADDITION");
		Console.WriteLine(" S -----------------SUBTRACTION");
		Console.WriteLine(" D -----------------DIVISION");
		Console.WriteLine(" M -----------------MULTIPLICATION");
		Console.WriteLine();
		Console.Write(" MAKE A CHOICE: ");
		choice = Convert.ToChar(Console.ReadLine());
		choice=Char.ToUpper(choice);
		/*if(!choice){
			Console.WriteLine(" Invalid Choice!");
			break;
		}*/
        Console.WriteLine(" Enter First Number:");
		num1 = float.Parse(Console.ReadLine());
		Console.WriteLine(" Enter Second Number:");
		num2 = float.Parse(Console.ReadLine());
		//float resultx=addNumbers(num1,num2);
		//Console.WriteLine("Addition - Result: " + resultx);
		switch (choice){
		case 'A':
		Console.WriteLine("Addition - Result: " + addNumbers(num1,num2));
		break;
		case 'S':
		Console.WriteLine("Subtraction - Result: " + subtract(num1,num2));
		break;
		case 'D':
		Console.WriteLine("Division - Result: " + divide(num1,num2));
		break;
		case 'M':
		Console.WriteLine("Multiplication - Result: " + multiply(num1,num2));
		break;
		default:
		Console.WriteLine("Invalid Choice Made!"); 
		break;
		}        
    }
	
	public static float addNumbers(float number1, float number2)
		{
			float result = number1 + number2;
			return result;
		}
	public static float subtract(float number1, float number2)
		{
			float result = number1 - number2;
			return result;
		}	
	public static float multiply(float number1, float number2)
		{
			float result = number1 * number2;
			return result;
		}
	public static float divide(float number1, float number2)
		{
			float result = number1 / number2;
			return result;
		}	

    }
}