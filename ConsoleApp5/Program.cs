#region About this program

/*
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/* 
 * Programmer: Jacob Brookhouse
 * Date: 08/27/2020
 * Purpose: Console app that displays point values and weight values, then calculates the average weight value.
 * Class: CITP 180
 * Assignment: Chapter 2 - Programming Excercise 8
 */

/*Task:
 *  Write a program that computes a weighted average giving the following weights.

    Homework: 10% Projects: 35% Quizzes: 10% Exams: 30% Final Exam: 15%

    Do a compile-time initialization with the following values: 

    Homework: 97; Projects: 82; Quizzes: 60; Exams: 75; Final Exam 80. 

    Display all values, including the weights, appropriately labeled and formatted. 
   
    Rerun the application with different values.
 */
#endregion

using System;


namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declared as constants cause they will not change, initialize values
			const int HomeworkWeight = 10;
			const int ProjectWeight = 35;
			const int QuizWeight = 10;
			const int ExamWeight = 30;
			const int FinalExamWeight = 15;

			// Declare the variables to store the values. Change for different output
			int Homework = 97;
			int Projects = 82;
			int Quizzes = 60;
			int Exams = 75;
			int FinalExam = 80;

			// Calculate by multiplying each and adding all together to find total
			double weightTotal = (HomeworkWeight * Homework) + (ProjectWeight * Projects) +
				(QuizWeight * Quizzes) + (ExamWeight * Exams) + (FinalExamWeight * FinalExam);

			// Calculate by dividing total by the added percentages and make it equal to the average
			double weightedAverage = weightTotal / (HomeworkWeight + ProjectWeight +
				QuizWeight + ExamWeight + FinalExamWeight);

			// Display all the values of each percentage, weights, and weight average
			// Display percentage values
			Console.WriteLine("Point Values");
			Console.WriteLine("Homework value: {0}", Homework);
			Console.WriteLine("Project value: {0}", Projects);
			Console.WriteLine("Quiz value: {0}", Quizzes);
			Console.WriteLine("Exam value: {0}", Exams);
			Console.WriteLine("Final Exam value:{0}", FinalExam);
			Console.WriteLine(Environment.NewLine);

			// Display weight values
			Console.WriteLine("Weight Values");
			Console.WriteLine("Homework Weight: {0}%", HomeworkWeight);
			Console.WriteLine("Project Weight: {0}%", ProjectWeight);
			Console.WriteLine("Quiz Weight: {0}%", QuizWeight);
			Console.WriteLine("Exam Weight: {0}%", ExamWeight);
			Console.WriteLine("Final Exam Weight: {0}%", FinalExamWeight);
			Console.WriteLine(Environment.NewLine);

			// Display the weighted average.
			Console.WriteLine("Weighted Average: {0:00.00}%", weightedAverage);

			Console.Read();
		}
	}
}
