using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

//students names
string[] studentsNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentsScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall\t\tGrade\t\tExtra Credits\n");

foreach (string name in studentsNames)
{
    string currenyStudentName = name;

    if (currenyStudentName == "Sophia")
        studentsScores = sophiaScores;
    else if (currenyStudentName == "Andrew")
        studentsScores = andrewScores;
    else if (currenyStudentName == "Emma")
        studentsScores = emmaScores;
    else if (currenyStudentName == "Logan")
        studentsScores = loganScores;
    else if (currenyStudentName == "Becky")
        studentsScores = beckyScores;
    else if (currenyStudentName == "Chris")
        studentsScores = chrisScores;
    else if (currenyStudentName == "Eric")
        studentsScores = ericScores;
    else if (currenyStudentName == "Gregor")
        studentsScores = gregorScores;
    else
        continue;


    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    decimal examScore = 0;
    decimal sumExamScores = 0;

    decimal extraCredits = 0;
    decimal sumExtraCredits = 0;

    foreach (int score in studentsScores)
    {
        gradedAssignments++;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
            sumExamScores += score;
        }
        else
        { 
            sumExtraCredits += score / 10;
            sumAssignmentScores += score / 10;
        }
            
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
    examScore = (decimal)sumExamScores / examAssignments;
    extraCredits = (decimal)sumExtraCredits / examAssignments;

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

    // ("Student\t\tExam Score\t\tOverall\t\tGrade|t|tExtra Credits\n");
    Console.WriteLine($"{currenyStudentName}\t\t{examScore}\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}\t\t {currentStudentGrade-extraCredits} ({extraCredits} pts)");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
