public class VerifyDisplay
{
    private List<bool> _displayWords = new();

    public List<bool> GetDisplayWords()
    {
        return _displayWords;
    }
    public bool GetDisplayWord(int index)
    {
        // List<bool> _displayableWords = GetDisplayWords();
        
        return _displayWords[index];
    }

    public void SetDisplayWords(int index, bool value)
    {
        _displayWords[index] = value;
    }

    public bool AreAllHidden()
    {
        foreach (bool word in _displayWords)
        {
            if (word == true)
            {
                return false;
            }
        }
        return true;
    }

    public void StartOver()
    {
        for (int item = 0; item <  _displayWords.Count; item++)
        {
            SetDisplayWords(item, true);
        }
    }
}