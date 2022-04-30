using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_as5
{
    internal class Program
    {

       
            class Bank
            {
                int money = 40000;
                String acctname ="Tejasree";
                String acctnum;
                static String bankname = "HDFC";
                static public int updatedBalance;
                public void depositMoney()
                {

                    Console.WriteLine("\nEnter the amount you want to deposit:");
                    int depMoney = int.Parse(Console.ReadLine());
                    updatedBalance = money + depMoney;
                    if (depMoney == 0)
                    {
                        Console.WriteLine("minimum deposit should be 100 ");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of " + acctname + " after deposit is " + updatedBalance);
                    }

                }
                public void withdrawMoney()
                {
                    try
                    {
                        Console.WriteLine("Welcome " + acctname + " your accountbalance: " + updatedBalance);
                        Console.WriteLine("\nEnter the amount you want to withdraw:");
                        int withdraw = int.Parse(Console.ReadLine());
                        updatedBalance = updatedBalance - withdraw;
                        if (withdraw > updatedBalance)
                        {
                            Console.WriteLine("insuffiecient balance");
                        }
                        else
                        {
                            Console.WriteLine("updated balance of " + acctname + " after withdrawal is " + updatedBalance);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Enter balance in number not in words, The input mismatched exception ");
                    }
                }
                public void Balance()
                {
                    Console.WriteLine("welcome to the " + bankname + "bank ");
                    Console.WriteLine("Enter account number: ");
                    acctnum = Console.ReadLine();
                    Console.WriteLine("Welcome " + acctname + " your accountbalance: " + money);

                }
            }
            static void Main(string[] args)
            {
                Bank bank = new Bank();
                bank.Balance();
                bank.depositMoney();
                bank.withdrawMoney();
                Console.ReadLine();
            }
        }
    }

        
        
    
