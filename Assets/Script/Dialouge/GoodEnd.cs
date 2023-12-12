using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodEnd : MonoBehaviour
{
    public DialougeManagerTest dialougeManagerTest;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public GameObject[] initialUiElements;
    public GameObject[] postCutsceneUiElements;

    private void Start()
    {
        DisableAllUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && !hasEnteredCollider)
        {
            StartCoroutine(ShowUIAndStartDialogue(initialUiElements));
            hasEnteredCollider = true;
        }
    }

    private void Interact()
    {
        // Additional interactions if needed
    }

    private void OnTriggerEnter2D(Collider2D other)
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
            StartCoroutine(ShowPostCutsceneUI());
        }
    }

    private IEnumerator ShowUIAndStartDialogue(GameObject[] uiElements)
    {
        foreach (GameObject uiElement in uiElements)
        {
            uiElement.SetActive(true);
            yield return new WaitForSeconds(3);
            uiElement.SetActive(false);
        }

        dialougeManagerTest.StartDialogue();
    }

    private IEnumerator ShowPostCutsceneUI()
    {
        yield return new WaitForSeconds(2); // Adjust the delay if needed

        foreach (GameObject uiElement in postCutsceneUiElements)
        {
            uiElement.SetActive(true);
        }
    }

    private void DisableAllUI()
    {
        foreach (GameObject uiElement in initialUiElements)
        {
            uiElement.SetActive(false);
        }

        foreach (GameObject uiElement in postCutsceneUiElements)
        {
            uiElement.SetActive(false);
        }
    }
}
