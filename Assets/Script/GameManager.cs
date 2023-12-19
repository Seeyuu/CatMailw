using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance

    public MoodData moodData; // Reference to the MoodData asset

    private void Awake()
    {
        // Ensure there's only one instance of the GameManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Optionally reset mood points when the game starts
        if (moodData != null)
        {
            moodData.ResetMood();


        }

       
    }
}
