﻿using static System.Console;
using System.Globalization;
partial class Program
{
    static void WhatMyNameSpace()
    {
        WriteLine("Name space Program : {0}", typeof(Program).Namespace);
    }
    static void Table(int number, byte size)
    {
        for(int i = 1; i <= size; i++)
        {
            WriteLine($"{number} x {i} = {number*i}");
        }
    }
    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M, // Switzerland
            "DK" or "NO" => 0.25M, // Denmark, Norway 
            "GB" or "FR" => 0.2M, // UK, France
            "HU" => 0.27M, // Hungary
            "OR" or "AK" or "MT" => 0.0M, // Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M, // California
            _ => 0.06M // Most other states.
        };

        return amount * rate;
    }
    static void ConfigureConsole(string culture = "en-Us", bool userComputerCulter = true)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!userComputerCulter)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        Console.WriteLine($"CurrentCulture : {CultureInfo.CurrentCulture.DisplayName}");
    }

    // Compile will reject negative number by devicalign values with uint
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;
        /*        switch (lastTwoDigits)
                {
                    case 11:
                        case 12:
                        case 13: return $"{number:N0}th";
                    default:
                        uint lastDigit = number % 10;
                        string suffix = lastDigit switch
                        {
                            1 => "st",
                            2 => "nd",
                            3 => "rd",
                            _ => "th"
                        };
                        return $"{number:N0} {suffix}";
                }*/
        string sufficValue = lastTwoDigits switch
        {
            11 or 12 or 13 => "th",
            _=> (number % 10) switch
            {
                1=>"st",
                2=>"nd",
                3=>"rd",
                _=> "th",
            },
        };
        return $"{number:N0} {sufficValue}";

    }

    static void RunCordianalToOrdinal(uint number)
    {
        for(uint i =1; i<=number; i++)
        {
            Console.WriteLine($"{CardinalToOrdinal(i)}");
        }
    }
    static int Factorial(int number)
    {
        if(number < 0)
        {
            throw new ArgumentOutOfRangeException(message: $"The factorial fuction is defined for non-negative integer ", paramName: nameof(number));
        }
        else if(number == 0)
        {
            return 1;
        }
        else
        {
            // Normal Method
            /*int factorialValue = 1;
            for (int i = number; i > 0; i--) 
            {
                factorialValue *= i;
            }
            return factorialValue;*/

            // Recurssion Method
            return number * Factorial(number - 1);
        }
    }
    static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }
    static int FibImperative(uint term)
    {
        if(term ==0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }

    }
    static void RunFibImperative()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
            arg0: CardinalToOrdinal(i),
            arg1: FibImperative(term: i));
        }
    }

    static int FibDeclarative(uint term)=> term switch
    {
        0 => throw new ArgumentOutOfRangeException(),
        1 => 0,
        2 => 1,
        _ => FibDeclarative(term - 1) + FibDeclarative(term - 2)
    };
    static void RunFibFunctional()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
           
            arg0: CardinalToOrdinal(i),
            arg1: FibDeclarative(term: i));
        }
    }


}