/*Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.Write("Введите число: ");
        bool palindrome = true;
        string x = Console.ReadLine();
        int c = x.Length - 1;
            for (int i = 0; i < c; i++)
            if (x[i] != x[c - i])
                palindrome = false;
        if (palindrome == true)
            Console.Write("Да");
        else Console.Write("Нет");