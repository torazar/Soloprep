﻿// See https://aka.ms/new-console-template for more information
using System;
  
public class GFG {
  
    static public void Main()
    {
        Console.Write("What is your first name? ");
    string firstName =    Console.ReadLine();
       
        Console.Write("What is your last name? ");
    string lastName =    Console.ReadLine();
       
       Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}