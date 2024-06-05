using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        bool _memorizeLoop = false;
        while (_memorizeLoop == false)
        {
            Reference scriptureref = new Reference();
            scriptureref.RefDisplay();
            Scripture scripture = new Scripture();
            scripture.Display();

            scripture.Display();
            int wordPlace = scripture.Rand();
            scripture.Replace(wordPlace);
            scripture.Display();

            {
                VerifyDisplay verify = new();
                List<bool> checke = verify._displayWords();
                if(checke.TrueForAll(element =>!element))
                {
                    _memorizeLoop = true;
                }
            }
        }
    }
}