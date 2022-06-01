//ADDING A HELPER FILE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utillities
    {
        //we have to make this public so it is accessible from the outside
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)//when we want to return a value we have to not include void and replace it with the type that we want it to return, in this case "int"
        {
            // Console.WriteLine($"{monthlyWage * numberOfMonthsWorked}");    
            // return monthlyWage * numberOfMonthsWorked;
            if(numberOfMonthsWorked == 12)//lets add a bonus
                return monthlyWage * (numberOfMonthsWorked + 1);
            else 
                return monthlyWage * numberOfMonthsWorked;
        }
        //Method Overloading
        //the two methods below are named the same as the method above. They are unique. The first one, because, there is more parameters. The second
        //because the data type is diff. Check which one is being called by placing a breakpoint at all methods
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"2nd - The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus, int test)
        {
            Console.WriteLine($"test - The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        //I do not yet know how to make it select this specific overload
        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"3rd - The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }


    }
}