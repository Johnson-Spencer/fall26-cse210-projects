
using System;
using System.Collections.Generic;

class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    
    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, verse);
        _words = ConvertToWords(text);
    }

    
    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

   
    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }

    
    public void ShowScripture()
    {
        Console.WriteLine(_reference.GetScriptureReference());

        foreach (Word word in _words)
        {
            word.Display();
        }

        Console.WriteLine();
    }

    
    public bool HideSomeWords()
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        
        if (visibleWords.Count == 0)
        {
            return false;
        }

        int index = _random.Next(visibleWords.Count);
        visibleWords[index].Hide();

        return true;
    }

    
    private int NumberOfHiddenWords()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }

    public bool AllWordsHidden()
    {
        return NumberOfHiddenWords() == _words.Count;
    }

    
    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }

        return tempWords;
    }
}
