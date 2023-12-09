using UnityEngine;

public class WrongHouse : MonoBehaviour
{
    [SerializeField] GameObject happy;
    [SerializeField] GameObject angry;
    [SerializeField] GameObject Gameover;
    [SerializeField] GameObject ButtonUI;

    public bool isCorrect;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public MoodData moodData; // Reference to MoodData

    private void Start()
    {
        //moodData.ResetMood(); // Reset the mood data
        UpdateMoodUi();
        ButtonUI.SetActive(false);
    }

    public void Update()
    {
        if (playerInRange && !isCorrect && Input.GetKeyDown(KeyCode.E) && !hasEnteredCollider)
        {
            GameManager.instance.moodData.CurrentMoodPoints--;
            Debug.Log(moodData.CurrentMoodPoints);
            UpdateMoodUi();
            hasEnteredCollider = true;
            ButtonUI.SetActive(false);
        }
    }

    void UpdateMoodUi()
    {
        if (moodData.CurrentMoodPoints >= moodData.maxMoodPoints)
        {
            happy.SetActive(true);
        }
        else if (moodData.CurrentMoodPoints >= moodData.minMoodPoints + 1&& moodData.CurrentMoodPoints < moodData.maxMoodPoints)
        {
            angry.SetActive(true);
        }
        else if (moodData.CurrentMoodPoints < moodData.minMoodPoints)
        {
            Gameover.SetActive(true);
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
