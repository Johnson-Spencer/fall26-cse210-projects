
class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    
    public ScriptureReference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

  
    public string GetScriptureReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_bookName} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

   
    public void DisplayScriptureReference()
    {
        Console.Write(GetScriptureReference());
    }
}
