﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Homework1
{
    static void Main()
    {

        /*problem 1.1
        #region
        Console.Write("Enter the temperature in degrees Celsius: ");
        int temperature = int.Parse(Console.ReadLine());

        if (temperature < 0)
        {
            Console.WriteLine("Freezing weather.");
        }
        else if (temperature >= 0 && temperature < 10)
        {
            Console.WriteLine("Cold weather.");
        }
        else if (temperature >= 10 && temperature < 20)
        {
            Console.WriteLine("Cool weather.");
        }
        else if (temperature >= 20 && temperature < 30)
        {
            Console.WriteLine("Moderate weather.");
        }
        else
        {
            Console.WriteLine("Warm weather.");
        }
        #endregion */

        /*problem1.2
        #region
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }
        #endregion */

        /*problem1.3
        #region
        Console.WriteLine("Choose the conversion direction:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");

        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());
        double temperature;
        double convertedTemperature;

        if (choice == 1)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            temperature = double.Parse(Console.ReadLine());
            convertedTemperature = (temperature - 32) * 5 / 9;
            Console.WriteLine($"Equivalent temperature in Celsius: {convertedTemperature:F2}°C");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Celsius: ");
            temperature = double.Parse(Console.ReadLine());
            convertedTemperature = (temperature * 9 / 5) + 32;
            Console.WriteLine($"Equivalent temperature in Fahrenheit: {convertedTemperature:F2}°F");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }
        #endregion */

        /*problem2.1
        #region
        int[] numbers = { 23, 45, 12, 67, 9, 32, 56, 18 };
        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine("Array: " + string.Join(", ", numbers));
        Console.WriteLine("Maximum Element: " + max);
        Console.WriteLine("Minimum Element: " + min);

        //problem2.2
        int[] numbers = { 23, 45, 12, 67, 9, 32, 56, 18 };
        int start = 0;
        int end = numbers.Length - 1;

        while (start < end)
        {
            int temp = numbers[start];
            numbers[start] = numbers[end];
            numbers[end] = temp;

            start++;
            end--;
        }

        Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));
        #endregion */

        /* problem2.2
        int[] numbers1 = { 23, 45, 12, 67, 9, 32, 56, 18 };
        ReverseArrayInPlace(numbers1);
        Console.WriteLine("Reversed Array: " + string.Join(", ", numbers1));
        */

        /* problem2.3
        #region
        int[] numbers = { 23, 45, 12, 67, 9, 32, 56, 18 };

        Console.WriteLine("Array: " + string.Join(", ", numbers));

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num < largest)
            {
                secondLargest = num;
            }
        }
        if (secondLargest != int.MinValue)
        {
            Console.WriteLine("Second Largest Element: " + secondLargest);
        }
        else
        {
            Console.WriteLine("Array has less than two elements.");
        }
        #endregion

        //problem2.4
        #region
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        Console.WriteLine("Sum Array: " + string.Join(", ", SumArrays(array1, array2)));
    }
    static int[] SumArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Input arrays must have the same length.");
        }
        int[] sumArray = new int[arr1.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            sumArray[i] = arr1[i] + arr2[i];
        }

        return sumArray;
    }
    #endregion */

    /* for 2.2
    static void ReverseArrayInPlace(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
    */
}

