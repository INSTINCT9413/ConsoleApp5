#region About this program

/* 
 * Programmer: Jacob Brookhouse
 * Date: 08/27/2020
 * Purpose: a short description about the program
 * Class: CITP 180
 * Assignment: Chapter 2 - Programming Excercise 8
 */

/*
 * Group Number: Group #1
 * Group Members: 
 */

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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
