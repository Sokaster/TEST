using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surname = "";
            int age = 0;
            int response = 0;
            while (response != -1)
            {
                Console.WriteLine(@"Enter 0 to enter name" + Environment.NewLine +
                                    "Enter -1 to exit" + Environment.NewLine +
                                    "Enter 1 to enter surname" + Environment.NewLine +
                                    "Enter 2 to enter age" + Environment.NewLine +
                                    "Enter -2 to print resume");

                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 0:
                        {
                            Console.WriteLine("Enter your name");
                            name = Console.ReadLine();
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter your surname");
                            surname = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -2:
                        {
                            Console.WriteLine(name);
                            Console.WriteLine(surname);
                            Console.WriteLine(age);
                            break;
                        }
                    case -1:
                        {
                            Console.WriteLine("YOU Exited programm");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("wrong number");
                            break;
                        }
                }
            }
            Console.ReadLine();
                
                /* if (response == 0)
                 {
                     Console.WriteLine("Enter your name");
                     name = Console.ReadLine();
                 }
                 if (response == 1)
                 {
                     Console.WriteLine("Enter your surname");
                     surname = Console.ReadLine();
                 }
                 if (response == 2)
                 {
                     Console.WriteLine("Enter age");
                     age = int.Parse(Console.ReadLine());
                 }
                 if (response == -2)
                 {
                     Console.WriteLine(name);
                     Console.WriteLine(surname);
                     Console.WriteLine(age);
                */
            }
        }
     
        
}   
