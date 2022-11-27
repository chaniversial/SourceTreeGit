﻿using System;

int solution(int year)
{
    if (year % 4 == 0)
    {
        if (year % 100 != 0)
            return 1;
        else if ((year % 100 == 0) && (year % 400 == 0))
            return 1;
        else
            return 0;
    }
    else
        return 0;
}


int num = int.Parse(Console.ReadLine());
Console.WriteLine(solution(num));