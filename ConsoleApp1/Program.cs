using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int select=0;
            while (select != 3)
            {
                Console.WriteLine("Please, select your calculation.");
                Console.WriteLine("1.Temperature Convertor");
                Console.WriteLine("2.Calculator");
                Console.WriteLine("3.Exit the program");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        int option;
                        do
                        {
                            int inputTempurature;
                            Console.WriteLine("Select the number(1~3) for the operation.");
                            Console.WriteLine("1.Convert Farenheit to Celsius.");
                            Console.WriteLine("2.Convert Farenheit to Kelvin.");
                            Console.WriteLine("3.Exit tempurature convertor.");
                            option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Input the farenheit temperature: ");
                                    inputTempurature = Convert.ToInt32(Console.ReadLine());
                                    float celsius = (inputTempurature - 32) * 5 / 9;
                                    Console.WriteLine("The temperature in Celsius is: " + celsius + "C");
                                    break;
                                case 2:
                                    Console.WriteLine("Input the farenheit temperature: ");
                                    inputTempurature = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("The temperature in Kelvin is: " + ((inputTempurature - 32) * 5 / 9) + 273.15 +"K");
                                    break;
                                case 3:
                                    Console.WriteLine("Exit the convertor!");
                                    break;
                                default:
                                    Console.WriteLine("Wrong selection, please reselect the menu!");
                                    break;
                            }
                        } while (option != 3);
                        break;
                    case 2:
                        Console.WriteLine("The simple calculator program.");
                        Console.WriteLine("Enter the first number: ");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        int caseSwitch;
                        do
                        {
                            Console.WriteLine("Select the number(1~4) for the operation. \n1.Add\n2.Minus\n3.Multiply\n4.Divide\n5.Re-enter the numbers.\n6.Exit");
                            caseSwitch = Convert.ToInt32(Console.ReadLine());
                            switch (caseSwitch)
                            {
                                case 1:
                                    Console.WriteLine("The result of " + firstNumber + "+" + secondNumber + " is " + (firstNumber + secondNumber));
                                    break;
                                case 2:
                                    Console.WriteLine("The result of " + firstNumber + "-" + secondNumber + " is " + (firstNumber - secondNumber));
                                    break;
                                case 3:
                                    Console.WriteLine("The result of " + firstNumber + "*" + secondNumber + " is " + (firstNumber * secondNumber));
                                    break;
                                case 4:

                                    Console.WriteLine("The result of " + firstNumber + "/" + secondNumber + " is " + (Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber)));
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the first number: ");
                                    firstNumber = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the second number: ");
                                    secondNumber = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 6:
                                    Console.WriteLine("Exit the calculation");
                                    break;
                                default:
                                    Console.WriteLine("Wrong selection, please reselect the menu!");
                                    break;
                            }
                        } while (caseSwitch != 6);
                        break;
                }
            }
        }
    }
}
