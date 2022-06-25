using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>(); 

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal studentGrade = decimal.Parse(input[1]);
                if (!students.ContainsKey(studentName))                
                   students.Add(studentName, new List<decimal>());
                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var value in student.Value)
                {
                    Console.Write($"{value:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
