using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScence1 : MonoBehaviour
{
    public DialougeManagerTest dialougeManagerTest;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public GameObject[] uiElements;
    private int currentIndex = 0;

    void Start()
    {
        DisableAllUI();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && !hasEnteredCollider)
        {
            StartCoroutine(ShowUI2Second());
           
            hasEnteredCollider = true;
        }
    }

    void Interact()
    {
        // Additional interactions if needed
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

    IEnumerator ShowUI2Second()
    {
        foreach (GameObject uiElement in uiElements)
        {
            uiElement.SetActive(true);
            yield return new WaitForSeconds(3);
            uiElement.SetActive(false);
        }
        dialougeManagerTest.StartDialogue();
    }

    void DisableAllUI()
    {
        foreach (GameObject uiElement in uiElements)
        {
            uiElement.SetActive(false);
        }
    }
}
