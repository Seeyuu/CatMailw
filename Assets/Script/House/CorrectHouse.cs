using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectHouse : MonoBehaviour
{
    [SerializeField] GameObject happy;
    [SerializeField] GameObject angry;
    [SerializeField] GameObject Gameover;
    [SerializeField] GameObject ButtonUI;

    public bool isCorrect;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public MoodData moodData; // Reference to MoodData

   // public AudioSource happymood;
   // public AudioSource notgood;

    private void Start()
    {
        //moodData.ResetMood(); // Reset the mood data
        UpdateMoodUi();
        ButtonUI.SetActive(false);
        
    }

    public void Update()
    {
        if (playerInRange && isCorrect && Input.GetKeyDown(KeyCode.E) && !hasEnteredCollider)
        {
            ButtonUI.SetActive(false);
            GameManager.instance.moodData.CurrentMoodPoints++;
            Debug.Log("Current Mood Points: " + GameManager.instance.moodData.CurrentMoodPoints);
            UpdateMoodUi();
            hasEnteredCollider = true;
        }
    }

    void UpdateMoodUi()
    {
        Debug.Log("Updating Mood UI. Current Mood Points: " + moodData.CurrentMoodPoints);

        if (moodData.CurrentMoodPoints == 5)
        {
            happy.SetActive(true);
        }
        else if (moodData.CurrentMoodPoints <= 2)
        {
            SceneManager.LoadScene(6);
        }
        else if (moodData.CurrentMoodPoints <= 4)
        {
            angry.SetActive(true);
        }
        else
        {
            // Handle other cases if needed
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isCorrect = true;
            playerInRange = true;
            ButtonUI.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        playerInRange = false;
        ButtonUI.SetActive(false);
    }
}
