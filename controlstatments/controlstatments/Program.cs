using System.Collections;
using System.Security.Permissions;

class Program
{
    static void Main()
    {
        //if-else-if statments 
        int marks = 20;
        char gradeLetter;
        if (marks >= 85)
        {
            gradeLetter = 'o';
        }
        else if (marks >= 60 && marks <= 85)
        {
            gradeLetter = 'A';

        }
        else if (marks >= 50 && marks < 60)
        {
            gradeLetter = 'B';

        }
        else if (marks >= 35 && marks < 50)
        {
            gradeLetter = 'c';

        }
        else
        {
            gradeLetter = 'f';
        }
        System.Console.WriteLine(gradeLetter);

        //switch case 
        char grade = 'A';
        string gradeDescription;
        switch (grade)
        {
            case 'O': gradeDescription = "Outstanding";break;
            case 'A': gradeDescription = "Excellent";break;
            case 'B': gradeDescription = "Good";break;
            case 'C': gradeDescription = "Average";break;
            case 'F': gradeDescription = "Fail";break;
            default: gradeDescription = "None";break;
        }
        System.Console.WriteLine(gradeDescription);




        //while and do-while 
        int i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine(i + "");
            i++;
        }
        i = 9;
        do
        {
            System.Console.WriteLine(i + "");
            i--;
        } while (i >= 0);
        //for loop

     ///   for (int j = 1; j <= 10; j++);
       // {
          //  System.Console.WriteLine(j);
      //  }
    }
}