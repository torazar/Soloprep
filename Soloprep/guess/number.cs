using System;

namespace Project_1 {
    class MainClass {
        public static void Main (string[] args) {
           Console.WriteLine("");
           int guess;
           string input;
           Random randomGenerator = new Random();
           int number = randomGenerator.Next(1, 11);
           Console.WriteLine("A magic number has been chosen. Can you guess it? ");
           while (true)
           {
               
           
           Console.Write("What is your guess? ");
input = Console.ReadLine();
guess = int.Parse(input);
           if (guess < number)
           {
               Console.WriteLine("Higher. ");
           }
else if (guess> number){
    Console.WriteLine("Lower. ");
}
else{
    Console.Write("You got it!");
    break;

}









           }
        }
    }
}