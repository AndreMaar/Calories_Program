using System.Collections.Generic;

public class HistoryMealClass
{
    public void AddHistoryMeal(string line)
    {
        string[] words = line.Split(' ');
        switch (words[0])
        {
            case "Breakfast":
                breakfast.Add(words[1] + " | " + words[2] + "gr | " + words[3] + "kcal");
                break;
            case "Lunch":
                lunch.Add(words[1] + " | " + words[2] + "gr | " + words[3] + "kcal");
                break;
            case "Dinner":
                dinner.Add(words[1] + " | " + words[2] + "gr | " + words[3] + "kcal");
                break;
        }
    }
    public List<string> breakfast = new List<string>();
    public List<string> lunch = new List<string>();
    public List<string> dinner = new List<string>();

    public void ClearAllLists()
    {
        breakfast.Clear();
        lunch.Clear();
        dinner.Clear();
    }
}

