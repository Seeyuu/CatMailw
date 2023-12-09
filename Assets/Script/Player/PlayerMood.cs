using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMood : MonoBehaviour
{
    [SerializeField] GameObject happy;
    [SerializeField] GameObject notJoy;
    [SerializeField] GameObject sad;

    public float startingPoint = 3;
    public float currentMood;
    
    
    void Start()
    {
        
        UpdateMoodDisplay();
    }

    private void Update()
    {
        
    }

    void UpdateMoodDisplay()
    {
        if(currentMood >= 3)
        {
            happy.SetActive(true);

        }else if(currentMood >= 2)
        {
            notJoy.SetActive(true);

        }else if(currentMood <= 1)
        {
            sad.SetActive(true);
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CorrectHouse") && Input.GetKeyDown(KeyCode.E))
        {
            currentMood = currentMood + 1;
            UpdateMoodDisplay();

        }
        else if (collision.CompareTag("Wrong") && Input.GetKeyDown(KeyCode.E))
        {
            currentMood = currentMood - 1;
            UpdateMoodDisplay();
        }
    }


}
