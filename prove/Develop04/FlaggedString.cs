class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt)
    {
        _prompt = prompt;
        _hasBeenUsed = false;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }

    public void SetHasBeenUsed(bool value)
    {
        _hasBeenUsed = value;
    }
}