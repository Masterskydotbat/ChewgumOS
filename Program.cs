using System;
using System.IO;

namespace second
{
    class Program
    {
        static void Main()  {

            string a = "12345";
            System.Console.WriteLine("Введите пароль");
            if(Console.ReadLine() == a) {
            bool isLoggedIn = true;
                if(isLoggedIn){
                    System.Console.WriteLine("Welcome to ChewgumOs");
                    System.Console.WriteLine("Available actions:");
                    System.Console.WriteLine("calc");
                    System.Console.WriteLine("notepad");
                    System.Console.WriteLine("Select the action you want to take: ");
                    string aboba = Console.ReadLine();
                    if(aboba == "calc") {
                        System.Console.Write("Enter action(add/subtract/divide/mult): ");
        string i = Convert.ToString(System.Console.ReadLine());
        if(i == "plus") {
            System.Console.WriteLine("Ok, продолжаем. Выполняется сложение.");
            System.Console.Write("Enter the first term (INTEGER NUMBERS ONLY): ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter the second term (INTEGER NUMBERS ONLY): ");
            int i2 = Convert.ToInt32(Console.ReadLine());
            int i3 = i1 + i2;
            System.Console.WriteLine("{0} is the answer ", i3);
            
        }
        else if(i == "minus") {
                System.Console.WriteLine("Ok, let's continue. Subtraction is performed.");
                System.Console.Write("Enter decrement (INTEGER NUMBERS ONLY):");
                 int imin1 = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter the subtracted (INTEGER NUMBERS ONLY):");
                 int imin2 = Convert.ToInt32(Console.ReadLine());
                 int imin3 = imin1 - imin2;
                 System.Console.WriteLine("{0} is the answer ", imin3);
            
        }
        else if(i == "razd") {
                System.Console.WriteLine("Ok, let's continue. We carry out division.");
                System.Console.Write("Enter the dividend (INTEGER NUMBERS ONLY):");
                 int irazd1 = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter the divisor (INTEGER NUMBERS ONLY):");
                 int irazd2 = Convert.ToInt32(Console.ReadLine());
                 int irazd3 = irazd1 / irazd2;
                 System.Console.Write("{0} is the answer ", irazd3);
            
        }
        else if(i == "umn") {
                System.Console.WriteLine("Ok, let's continue. We carrying out multiplication.");
                System.Console.Write("Enter the first factor (INTEGER NUMBERS ONLY): ");
                 int iumn1 = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter the second factor (INTEGER NUMBERS ONLY):  ");
                 int iumn2 = Convert.ToInt32(Console.ReadLine());
                 int iumn3 = iumn1 * iumn2;
                 System.Console.Write("{0} is the answer ", iumn3);
            
        }
            else {
                return;
            }
                    }
                  else if(aboba == "notepad") {
                        System.Console.WriteLine("Welcome to notepad!");
                        System.Console.WriteLine("You are in edit mode");
                        System.Console.WriteLine("Type .leave twice if you want to leave from notepad");

                        while(Console.ReadLine() != ".leave") {
                            Console.Write(" ");
                        }
                        if(Console.ReadLine() == ".leave") {
                            return;
                        }
                    }
                }

            }
            else {
                
                System.Console.WriteLine("попробуйте еще раз");


            }
            
            
            

        }
   }
}