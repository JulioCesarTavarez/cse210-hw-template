public class Scripture
{

    public List<string> _words = new List<string>()
    {
        "For", "God", "so", "loved", "the", "world", "that", "he", "gave", "his", "one", "and", "only", "Son",
    };

    public string reference = "John 3:16";
    VerifyDisplay _verify = new();
    public Scripture()
    {
        foreach (string word in _words)
        {
            _verify._displayWords.Add(true);
        }
    }
    public void Display()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_verify._displayWords[i] == true)
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
        int randomOpt = rand.Next(0, _words.Count);
        return randomOpt;
    }

    public void Replace(int option)
    {
        _verify._displayWords[option] = false;

    }
    // public List<string> replaced = new List<string>();

    // foreach (string word in _words)
    // {
    //     if (word == _words[randomOpt])
    //     {
    //         replaced.Add("___");
    //     } 
    // }




}