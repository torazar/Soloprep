
using System;

namespace Project_1 {
    class MainClass {
        public static void Main (string[] args) {
        string letter;
Console.Write("Welcome to the grade calculator! What is your grade? ");
string grades = Console.ReadLine();
int grade = int.Parse(grades);
if(grade > 90){letter = "A";}
else if (grade>80){letter = "B";}
else if (grade>70){letter = "C";}
else if (grade>60){letter = "D";}
else{letter = "F";}
Console.WriteLine($"Your letter grade is {letter}. Good job!");
if (grade>70){
    Console.WriteLine($"Congratulations! You passed the class!");
}
else {
    Console.WriteLine($"You failed! You better do better next time!");
}

        }
    }
}