using System;

namespace CSharpFundamentalsCourse.CalculateGrades_Pt1 
{
    public class CalculateGrades_Pt1
    {
        public static void Main(string[] args)
        {
            CalculateStudentGrades();
        }

        public static void CalculateStudentGrades()
        {
            // initialize variables - graded assignments 
            var sophiaScores = new List<double> { 93, 87, 98, 95, 100 };
            var nicolasScores = new List<double> { 80, 83, 82, 88, 85 };
            var zahirahScores = new List<double> { 84, 96, 73, 85, 79 };
            var jeongScores = new List<double> { 90, 92, 98, 100, 97 };
            int numberOfAssignments = sophiaScores.Count();

            double sophiaAvg = sophiaScores.Sum() / numberOfAssignments;
            double nicolasAvg = nicolasScores.Sum() / numberOfAssignments;
            double zahirahAvg = zahirahScores.Sum() / numberOfAssignments;
            double jeongAvg = jeongScores.Sum() / numberOfAssignments;

            Console.WriteLine($"Sums after {numberOfAssignments} assignments");
            Console.WriteLine("Sophia: " + sophiaScores.Sum());
            Console.WriteLine("Nicolas: " + nicolasScores.Sum());
            Console.WriteLine("Zahirah: " + zahirahScores.Sum());
            Console.WriteLine("Jeong: " + jeongScores.Sum());
            Console.WriteLine();

            Console.WriteLine("Averages after {numberOfAssignments} assignments:");
            Console.WriteLine("Sophia: " + sophiaAvg);
            Console.WriteLine("Nicolas: " + nicolasAvg);
            Console.WriteLine("Zahirah: " + zahirahAvg);
            Console.WriteLine("Jeong: " + jeongAvg);

            // calculate gpa
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;


            int gradeA = 4;
            int gradeB = 3;


            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;
            Console.WriteLine();
            Console.WriteLine("Sohpia's Grades: ");
            Console.WriteLine($"{course1Name} {course1Grade}");
            Console.WriteLine($"{course2Name} {course2Grade}");
            Console.WriteLine($"{course3Name} {course3Grade}");
            Console.WriteLine($"{course4Name} {course4Grade}");
            Console.WriteLine($"{course5Name} {course5Grade}");

            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

            Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
            Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
            Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
            Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
            Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}