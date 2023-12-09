using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoodUI : MonoBehaviour
{
    [SerializeField] GameObject happy;
    [SerializeField] GameObject angry;
    [SerializeField] GameObject Gameover;

    public bool isCorrect;
    public bool playerInRange;
    
    public int moodPoint = 5;
    public int currentPoint;


    //äÁèä´éãªé
    private void Start()
    {
        
        UpdateMoodUi();


    }
    public void Update()
    {
        if(playerInRange && isCorrect && Input.GetKeyDown(KeyCode.P))
        {
            currentPoint++;
            Debug.Log(currentPoint);
            UpdateMoodUi();
            
        }else if(playerInRange && !isCorrect && Input.GetKeyDown(KeyCode.P))
        {
            currentPoint--;
            Debug.Log(currentPoint);
            UpdateMoodUi();

        }
        else
        {

        }
    }

    void UpdateMoodUi()
    {
        if(currentPoint >= 5)
        {
            happy.SetActive(true);
        }else if (currentPoint >= 3 && currentPoint < 5)
        {
            angry.SetActive(true);
        }else if (currentPoint < 2)
        {
            Gameover.SetActive(true);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CorrectHouse")){
            isCorrect = true;
            playerInRange = true;
            
        }else if (other.CompareTag("Wrong"))
        {
            isCorrect = false;
            playerInRange = true;
            
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        playerInRange = false;
    }


    //àªç¤ÇèÒãªé¡ÑÂobjectäË¹
    //GameObject myGameObject = gameObject;

    // You can also access the name of the GameObject
    //string objectName = myGameObject.name;

    //Debug.Log("This script is attached to: " + objectName);
}
