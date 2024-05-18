using System;
using Microsoft.VisualBasic;

public static class PromptGenerator
{
    // I had to get help from Chat GPT here because I didnt know how to use the random generator.
    private static readonly List<string> prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What was the lowlight of your day?",
        "What is the weirdest thing you saw today?",
        "Who did you run into today?",
        "What time did you wake up today?"
    };

    public static string GetRandomPrompt()
    {
        Random rand = new();
        return prompts[rand.Next(prompts.Count)];
    }
}
