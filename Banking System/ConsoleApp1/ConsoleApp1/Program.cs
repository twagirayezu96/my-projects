using System;

namespace ConsoleApp1
{
    class Bank
    {

        static void Main(string[] args)
        {
            
            int amount = 50000, deposit, withdraw;
            int choice, pin = 0, x = 0;
            int gender;
            Console.WriteLine("Enter Your Pin ");
            pin = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("WELCOME TO BANK SERVICE\n");
                Console.WriteLine(" Enter your Firstname");
                string firstname = Console.ReadLine();
                Console.WriteLine(" Enter your Lastname");
                string Lastname = Console.ReadLine();
                Console.WriteLine(" choose your  gender");
                Console.WriteLine("1. Female\n");
                Console.WriteLine("2. Male\n");
                gender =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Account Number");
                int account = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS RFW : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }

                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;
                       default:
                        Console.WriteLine("\n THANK YOU…");  
                        break;
                }

                Console.WriteLine("\n\n THANKS FOR USING CST BANK SERVICE ");

            }

        }

        }
    }