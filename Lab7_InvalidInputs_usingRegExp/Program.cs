using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7_InvalidInputs_usingRegularExpressions
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter your first name: ");
            string ValidName = Console.ReadLine();
            if (IsName(ValidName))
            {
                Console.WriteLine("\nThank you for inputting your name correctly.");
            }
            else
            {
                Console.WriteLine("Sorry, input is not valid.");
            }


            Console.WriteLine("Please enter your email address: ");
            string ValidEmail = Console.ReadLine();
            if (IsEmail(ValidEmail))
            {
                Console.WriteLine("\nThank you for inputting your Email Address correctly.");
            }
            else
            {
                Console.WriteLine("Sorry, input is not valid.");
            }


            Console.WriteLine("Please enter your Phone Number: xxx-xxx-xxxx");
            string ValidPhone = Console.ReadLine();
            if (IsPhone(ValidPhone))
            {

                Console.WriteLine("\nThank you for the valid phone number.");
            }
            else
            {
                Console.WriteLine("Sorry, input is not valid.");
            }


            Console.WriteLine("\nPlease enter today's date: dd/mm/yyyy ");
            string ValidDate = Console.ReadLine();
            if (IsDate(ValidDate))
            {
                Console.WriteLine("Thank you for entering a correct date.");
            }
            else
            {
                Console.WriteLine("Sorry, input is not valid.");
            }


            Console.WriteLine("\nPlease enter an HTML element");
            string ValidHTML = Console.ReadLine();
            if (IsHTML(ValidHTML))
            {
                Console.WriteLine("Thank you for entering a HTML element.");
            }
            else
            {
                Console.WriteLine("Sorry, input is not valid.");
            }



            Console.ReadKey();
        }

        //Beginning of METHODS
        static bool IsName(string ValidName)
        {
            if (Regex.IsMatch(ValidName, "^[A-Z]{1,}[A-Za-z]{2,28}[^_]"))
            {
                //If Name is input correctly, then it is true. The same was duplicated for each method
                return true;
            }
            //If Name is input incorrectly, then it is false.  The same was duplicated for each method
            return false;
        }


        static bool IsEmail(string ValidEmail)
        {
            if (Regex.IsMatch(ValidEmail, @"[\w]{5,30}@[\w]{5,10}.\w{2,3}"))
            {
                return true;
            }
            return false;
        }


        static bool IsPhone(string ValidPhone)
        {
            if (Regex.IsMatch(ValidPhone, @"\d{3,}[-]\d{3,}[-]\d{4}"))
            {
                return true;
            }
            return false;
        }


        static bool IsDate(string ValidDate)
        {
            //Need more work on the date validation. It will return incorrect dates.  
            //Just verifies that there are two numbers for dd and mm
            //Not in correct format
            if (Regex.IsMatch(ValidDate, @"^\d{2,2}/\d{2,2}/\d{4,4}$"))
            {
                return true;
            }
            return false;
        }


        static bool IsHTML(string ValidHTML)
        {
            if (Regex.IsMatch(ValidHTML, @"([<p>]\S[</p>])|([<h1>]\S[<h1>])"))
            {
                return true;
            }
            return false;
        }


    }
}