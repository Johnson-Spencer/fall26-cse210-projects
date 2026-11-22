using System;
using System.Collections.Generic;
using System.IO;

class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private string _filename = "";
    private int _totalScore = 0;

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }

        DisplayScore();
    }

    public void DisplayScore()
    {
        int level = (_totalScore / 1000) + 1;

        Console.WriteLine($"\nScore: {_totalScore}");
        Console.WriteLine($"Level: {level}");
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int pointsEarned = _goals[choice].RecordEvent();
            _totalScore += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename: ");
        _filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(_filename))
        {
            output.WriteLine(_totalScore);

            foreach (BaseGoal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename: ");
        _filename = Console.ReadLine();

        if (!File.Exists(_filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(_filename);
        _totalScore = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
            {
                _goals.Add(new SimpleGoal(
                    parts[1], parts[2], int.Parse(parts[3]),
                    bool.Parse(parts[4])));
            }
            else if (parts[0] == "Eternal")
            {
                _goals.Add(new EternalGoal(
                    parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "Checklist")
            {
                _goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6]),
                    bool.Parse(parts[7])));
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}