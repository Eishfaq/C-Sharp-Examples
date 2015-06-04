using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //---------------============= Do while whith shooping cart ==============------------
            //string choose = string.Empty;
            //int totalCoffeePrice = 0;
            //do
            //{

            //    Console.WriteLine("Please Choose One: 1-Small, 2-Medium, 3-Large");
            //    int option = int.Parse(Console.ReadLine());
            //    Console.WriteLine("You have choosed {0}", option);
            //    totalCoffeePrice += option;


            //    do
            //    {
            //        Console.WriteLine("Do you want to order more? Press Yes or No: ");
            //        choose = Console.ReadLine().ToUpper();
            //        if (choose != "YES" && choose != "NO")
            //        {
            //            Console.WriteLine("Invalid! Type YES or NO to continue.");
            //        }
            //    } while (choose != "YES" && choose != "NO");
            //} while (choose == "YES"); 

            //Console.WriteLine("Thank you for your purches.");
            //Console.WriteLine("Total Bill : " + totalCoffeePrice);


            //----------------====================   Do while   ==================---------------
            //int number;
            //string choice = string.Empty;
            //do
            //{
            //    Console.WriteLine("Enter your target");

            //    number = int.Parse(Console.ReadLine());
            //    int start = 0;
            //    while (start <= number)
            //    {
            //        Console.WriteLine(start);
            //        start = start + 2;
            //    }



            //    do
            //    {
            //        Console.WriteLine("Do you want to enter another target ?");
            //        choice = Console.ReadLine().ToUpper();

            //        if (choice != "YES" && choice != "NO")
            //        {
            //            Console.WriteLine("Invalid! Please enter YES or NO");

            //        }
            //    } while (choice != "YES" && choice != "NO");

            //} while (choice == "YES"); 

            //Console.WriteLine("Finished!");



            //----------===========while loop=============------------

            //Console.WriteLine("Please enter a Number: ");
            //int number = int.Parse(Console.ReadLine());
            //int start = 0;
            //Console.WriteLine("Even numbers: ");
            //while (start <= number)
            //{
            //                                                  //Console.WriteLine(start);
            //    //alternative                                 //start = start + 2;
            //    if (start%2 == 0)
            //    {
            //        Console.WriteLine(start);

            //    }
            //    start++;
            //}

            //----------=========== Switch-case, goto =========-------------

            //int totalCoffeeCost = 0;
            //Start:
            //Console.WriteLine("Choose your manu, 1 - small, 2- medium, 3 - large");

            //int choose = int.Parse(Console.ReadLine());

            //switch (choose)
            //{
            //    case 1:
            //        totalCoffeeCost += 1;
            //        break;

            //    case 2:
            //        totalCoffeeCost += 2;
            //        break;

            //    case 3:
            //        totalCoffeeCost += 3;
            //        break;

            //    default:
            //        Console.WriteLine("Invalid! selection.");
            //        goto Start;
            //}

            //Console.WriteLine("Do you want to order more? (yes/no):");
            //Again:
            //string more = Console.ReadLine().ToUpper();
            //switch (more)
            //{
            //    case "YES":
            //        goto Start;
            //    case "NO":
            //        break;
            //    default:
            //        Console.WriteLine("warning ! select yes or no.");
            //        goto Again;
            //}

            //int total = 0;

            //total += totalCoffeeCost;

            //Console.WriteLine("Total cost is : {0}",total);



            //-------------=========Type casting ============-------------------

            //string str = "100mg";


            //int result = 0;
            //bool ans = int.TryParse(str,out result);



            //if (ans)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("not possible!");
            //}



            //----------=============not null and nullable types============------------
            //int? TicketForSale = null;
            //int AvailableTicket;

            //if (TicketForSale == null)
            //{
            //    AvailableTicket = 0;
            //}
            //else
            //{
            //    AvailableTicket = (int)TicketForSale;
            //}
            //Console.WriteLine("Available: " + AvailableTicket);




            ////===========--------switch case example---------------============

            //Console.Write("Enter Your Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Are you Major (y/n)? ");
            //string x = Console.ReadLine();

            //switch (x)
            //{
            //    case "y" : 
            //        Console.WriteLine("i am major.");
            //        break;

            //    case "n":
            //        Console.WriteLine("I am not a Major");
            //        break;
            //    default:
            //        Console.WriteLine("User did not answer!");
            //        break;
            //}

        }
    }
}
