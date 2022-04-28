// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
namespace Project_1 {
    class MainClass {
        public static void Main (string[] args) {
            List<int> numbers = new List<int>();
    Console.WriteLine("Enter a list of numbers, type 0 when finsihed.");
    int number = -1;
    int sum = 0;
    float average;
    int largest = 0;
    while (number != 0){
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        number = int.Parse(input);
        if (number != 0){
 numbers.Add(number);
        }
       
    }
    for (int i = 0; i< numbers.Count; i++){
        sum = sum + numbers[i];
        if (largest < numbers[i]){
            largest = numbers[i];
        }
    }
    average = sum / numbers.Count;
    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number is: {largest}");
        }
    }
}
    

