using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1._jobTitle="Software Engineer";
        Job job2 = new();
        job1._company="Microsoft";
        job1._startYear=2019;
        job1._endYear=2022;
        job2._jobTitle="Manager";
        job2._company="Apple";
        job2._startYear=2022;
        job2._endYear=2023;
        
        job1.Display();
        job2.Display();


    Resume myResume = new();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

    Console.WriteLine($"{myResume._jobs[0]._jobTitle}");

    }
}