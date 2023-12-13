using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongHouse : MonoBehaviour
{
    [SerializeField] GameObject happy;
    [SerializeField] GameObject angry;
    //SerializeField] GameObject Gameover;
    [SerializeField] GameObject ButtonUI;

    public bool isCorrect;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public MoodData moodData; // Reference to MoodData

    //public AudioSource happymood;
    //public AudioSource notgood;

    private void Start()
    {
        
        UpdateMoodUi();
        ButtonUI.SetActive(false);
    }

    public void Update()
    {
        if (GameManager.instance != null && GameManager.instance.moodData != null)
        {
            if (playerInRange && !isCorrect && Input.GetKeyDown(KeyCode.E) && !hasEnteredCollider)
            {
                GameManager.instance.moodData.CurrentMoodPoints--;
                Debug.Log(GameManager.instance.moodData.CurrentMoodPoints);
                UpdateMoodUi();
                hasEnteredCollider = true;
                ButtonUI.SetActive(false);
            }
        }
        else
        {
            Debug.LogError("GameManager or MoodData not available!");
        }
    }


    void UpdateMoodUi()
    {
        Debug.Log("Updating Mood UI. Current Mood Points: " + moodData.CurrentMoodPoints);

        if (moodData.CurrentMoodPoints == 5)
        {
            happy.SetActive(true);
        }
        else if (moodData.CurrentMoodPoints <= 4)
        {
            angry.SetActive(true);
        }
        else if (moodData.CurrentMoodPoints < 2)
        {
            Debug.Log("Loading Scene 6");
            SceneManager.LoadScene(0);
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isCorrect = false;
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
