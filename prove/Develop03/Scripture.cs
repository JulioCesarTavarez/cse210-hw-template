public class Scripture
{

    private List<string> _words = new List<string>()
    {
        "For", "God", "so", "loved", "the", "world", "that", "he", "gave", "his", "one", "and", "only", "Son",
    };


    private VerifyDisplay _verify = new();
    public Scripture()
    {
        foreach (string word in _words)
        {
            _verify.GetDisplayWords().Add(true);
        }
    }
    public void Display()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_verify.GetDisplayWord(i) == true)
            {
                Console.Write($"{_words[i]} ");
            }
            else
            {
                Console.Write("___ ");
            }
        }
    }

    public int Rand()
    {
        
        Random rand = new();
        int randomOpt;
        do
        {
            randomOpt = rand.Next(0, _words.Count);
        }while(_verify.GetDisplayWord(randomOpt) == false);
        return randomOpt;
    }

    public void Replace(int option)
    {
        _verify.SetDisplayWords(option, false);

    }

    public void StartOver()
    {
        _verify.StartOver();
    }

    public bool AreAllWordsMemorized()
    {
        return _verify.AreAllHidden();
    }
        



}