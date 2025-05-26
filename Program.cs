using System;
using System.Collections.Generic;

// initialize variables - graded assignments 
int examAssignments = 5;

// Use a dictionary for easier student lookup
var studentScoresDict = new Dictionary<string, int[]>
{
    { "Sophia", new int[] { 90, 86, 87, 98, 100, 94, 90 } },
    { "Andrew", new int[] { 92, 89, 81, 96, 90, 89 } },
    { "Emma", new int[] { 90, 85, 87, 98, 68, 89, 89, 89 } },
    { "Logan", new int[] { 90, 95, 87, 88, 96, 96 } },
    { "Becky", new int[] { 92, 91, 90, 91, 92, 92, 92 } },
    { "Chris", new int[] { 84, 86, 88, 90, 92, 94, 96, 98 } },
    { "Eric", new int[] { 80, 90, 100, 80, 90, 100, 80, 90 } },
    { "Gregor", new int[] { 91, 91, 91, 91, 91, 91, 91 } }
};

string[] studentsNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tExam Score\tOverall\t\tGrade\t\tExtra Credits\n");

foreach (string studentName in studentsNames)
{
    if (!studentScoresDict.TryGetValue(studentName, out int[]? scores))
        continue;

    int sumAssignmentScores = 0;
    decimal sumExamScores = 0;
    decimal sumExtraCredits = 0;

    for (int i = 0; i < scores.Length; i++)
    {
        if (i < examAssignments)
        {
            sumAssignmentScores += scores[i];
            sumExamScores += scores[i];
        }
        else
        {
            decimal extraCredit = (decimal)scores[i] / 10;
            sumExtraCredits += extraCredit;
            sumAssignmentScores += (int)extraCredit;
        }
    }

    decimal currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
    decimal examScore = sumExamScores / examAssignments;
    decimal extraCredits = sumExtraCredits / examAssignments;

    decimal gradeWithoutExtraCredits = currentStudentGrade - extraCredits; // new variable

    string currentStudentLetterGrade;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{studentName}\t\t{examScore:F1}\t\t{currentStudentGrade:F1}\t\t{currentStudentLetterGrade}\t\t{gradeWithoutExtraCredits:F1} ({extraCredits:F1} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
