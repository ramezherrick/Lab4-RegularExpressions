using System;
using System.Text.RegularExpressions;

namespace Lab7_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine(ValidateNames(name));

                Console.WriteLine("Enter email");
                string email = Console.ReadLine();
                Console.WriteLine(Validateemail(email));

                Console.WriteLine("Enter phone number {area code of 3 digits} - {3 digits} - {4 digits}");
                string number = Console.ReadLine();
                Console.WriteLine(ValidatePhone(number));

                Console.WriteLine("Enter date dd/mm/yyyy");
                string date = Console.ReadLine();
                Console.WriteLine(ValidateDate(date));

                Console.WriteLine("Enter HTML");
                string html = Console.ReadLine();
                Console.WriteLine(ValidateHtml(html));

            }
        }
        public static bool ValidateNames(string str)
        {
            if (Regex.IsMatch(str, @"^([A-Z][a-z]{1,29})$"))
            {
                return true;
            }
            else return false;
        }
        public static bool Validateemail(string str)
        {
            if (Regex.IsMatch(str, @"^([A-z0-9\.]{5,30}[@][A-z\.]{5,10}[.][A-z]{2,3})$")) return true;
            else return false;
        }
        public static bool ValidatePhone (string str)
        {
            if (Regex.IsMatch(str, @"\b([0-9]{3}\-[0-9]{3}\-[0-9]{4})\b"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateDate(string str)
        {
            if (Regex.IsMatch(str, @"\b([012][0-9]|[3][01])[/]([0][0-9]|[1][012])[/][012][0-9][0-9][0-9]\b"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateHtml(string str)
        {
            if (Regex.IsMatch(str, @"[<][A-z][A-z0-9]*[>][A-z0-9\\\*\.\(\)\{\}]*[<][/][A-z0-9]*[>]"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

