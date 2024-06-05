using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
            Reference scriptureref = new Reference();
            scriptureref.RefDisplay();
            Scripture scripture = new Scripture();
            scripture.Display();
            Console.WriteLine($"\n\nTo continue hit enter to quit please enter Q");
            string quit = Console.ReadLine();
            bool memorizeLoop = false;
            if (quit == "Q")
            {
                memorizeLoop = true;
            }else
            {
                memorizeLoop = false;
            }



        while (memorizeLoop == false)
        {
            Console.Clear();
            scriptureref.RefDisplay();

            int wordPlace = scripture.Rand();
            scripture.Replace(wordPlace);
            scripture.Display();

            Console.WriteLine($"\nTo continue hit enter to quit please enter Q");
            quit = Console.ReadLine();
            if (quit.ToUpper() == "Q")
            {
                memorizeLoop = true;
            }

            if (scripture.AreAllWordsMemorized() == true)
            {
                scripture.StartOver();
            }

            
            // {
            //     VerifyDisplay verify = new();
            //     List<bool> checke = verify._displayWords;
            //     if(checke.TrueForAll(element =>!element))
            //     {
            //         memorizeLoop = true;
            //     }
            // }
        }
    }
}