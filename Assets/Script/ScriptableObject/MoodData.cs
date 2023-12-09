using UnityEngine;

[CreateAssetMenu(fileName = "NewMoodData", menuName = "Mood System/Mood Data")]
public class MoodData : ScriptableObject
{
    public int startingMoodPoints = 5;
    public int maxMoodPoints = 5;
    public int minMoodPoints = 0;

    private int currentMoodPoints;

    public int CurrentMoodPoints
    {
        get { return currentMoodPoints; }
        set
        {
            currentMoodPoints = Mathf.Clamp(value, minMoodPoints, maxMoodPoints);
        }
    }

    public void ResetMood()
    {
        currentMoodPoints = startingMoodPoints;
    }

    // You can add more properties or methods as needed
}
