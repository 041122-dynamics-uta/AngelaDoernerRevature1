using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {
        int y = Convert.ToInt32(Console.ReadLine());
        var monthDays = new int[9];
        monthDays[0] = 31; // Jan
        monthDays[1] = 28; // Feb
        monthDays[2] = 31; // Mar
        monthDays[3] = 30; // Apr
        monthDays[4] = 31; // May
        monthDays[5] = 30; // Jun
        monthDays[6] = 31; // Jul
        monthDays[7] = 31; // Aug
        monthDays[8] = 30; // Sep

        if (y <= 1917) // Julian Calendar
        {
            if (y % 4 == 0)
            {
                monthDays[1] = 29;
            }
        }
        else if (y >= 1919) // Gregorian Calendar
        {
            if (y % 400 == 0 || y % 4 == 0 && y % 100 != 0) 
            {
                monthDays[1] = 29;
            }
        }
        else
        {
            // 1918
            monthDays[1] = 15;
        }

        var total = 0;
        var monthNumber = 0;

        while (256 - total > 30)
        {
            total += monthDays[monthNumber];
            monthNumber++;
        }

        var septDay = 256 - total;

        Console.WriteLine($"{septDay:00}.{9:00}.{y:0000}");
    }
}