using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondHouse : MonoBehaviour
{
    public DialougeManagerTest dialougeManagerTest;
   
    public bool playerInRange;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            dialougeManagerTest.StartDialogue();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialougeManagerTest.EndDialogue();
            
        }
    }

   
}
