using System;
using Microsoft.VisualBasic;

public class Prompt
{



    static void JournalPrompts()
    {
        List<string> questions = new();
        string question1 = "What was the highlight of your day?";
        string question2 = "What was the lowlight of your day?";
        string question3 = "What is the wierdest thing you saw today";
        string question4 = "Who did you run into today?";
        string question5 = "What time did you wake up today?";

        questions.Add(question1);
        questions.Add(question2);
        questions.Add(question3);
        questions.Add(question4);
        questions.Add(question5);
    }    
    

}