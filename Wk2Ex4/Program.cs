﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display ATM menu.
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            // Convert user input to integer.
            int option = Convert.ToInt32(Console.ReadLine());
            // set initial balance and initialize it.
            double balance = 1000;

            // To keep the user in the bank app. 
            while (option < 4)

            {
                // switch to compare option variable to cases.
                switch (option)
                {
                    // first case if they pressed one and they want to check balance.
                    case 1:
                        // display balance.
                        Console.WriteLine("Your balance is " + balance);
                        // display bank menu.
                        Console.WriteLine("ATM Menu:");
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("2. Deposit");
                        Console.WriteLine("3. Withdraw");
                        Console.WriteLine("4. Exit");
                        Console.Write("Choose an option: ");
                        // Choose new option.
                        option = Convert.ToInt32(Console.ReadLine());
                        // break to exit case
                        break;
                    // Second case if the user wants to deposit
                    case 2:
                        {
                            // Prompts user to enter deposit amount.
                            Console.WriteLine("Enter a deposit amount: ");
                            // initialize deposit value from user and turn into variable.
                            double deposit = Convert.ToDouble(Console.ReadLine());
                            // Calculate new sum of the balance.
                            balance += deposit;
                            // Display bank menu.
                            Console.WriteLine("Deposit successful.");
                            Console.WriteLine("ATM Menu:");
                            Console.WriteLine("1. Check Balance");
                            Console.WriteLine("2. Deposit");
                            Console.WriteLine("3. Withdraw");
                            Console.WriteLine("4. Exit");
                            Console.Write("Choose an option: ");
                            // Get new user option.
                            option = Convert.ToInt32(Console.ReadLine());
                            // break to exit case.
                            break;
                        }
                    // Third case if the user wants to withdraw.
                    case 3:
                        {
                            // Prompt user for withdraw amount.
                            Console.WriteLine("Enter withdraw amount");
                            // Initialize and collect withdraw variable
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            // Calculate new balance sum
                            balance -= withdraw;
                            // Display bank menu
                            Console.WriteLine("Withdrawel successful");
                            Console.WriteLine("ATM Menu:");
                            Console.WriteLine("1. Check Balance");
                            Console.WriteLine("2. Deposit");
                            Console.WriteLine("3. Withdraw");
                            Console.WriteLine("4. Exit");
                            Console.Write("Choose an option: ");
                            option = Convert.ToInt32(Console.ReadLine());
                            // break to exit case
                            break;
                        }
                    default: { break; } // default case if the user want to exit or presses any other key
                }
            }
        }
    }
}
