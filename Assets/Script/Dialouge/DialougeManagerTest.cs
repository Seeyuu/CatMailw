using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManagerTest : MonoBehaviour
{
    public Text dialogueText;
    public GameObject dilogueBg;
    public string[] dialogueLines;
    private int currentLine = 0;
    private bool dialogueActive = false;

    public GameObject[] finishUIElements; // An array to hold your UI elements.
    public PlayerMovement playerMovement;

    void Start()
    {
        dialogueText.gameObject.SetActive(false);
        dilogueBg.SetActive(false);

        playerMovement = FindObjectOfType<PlayerMovement>();
        if (playerMovement == null)
        {
            Debug.LogError("cannot found");
        }
        else
        {
            playerMovement.enabled = true;
        }
    }

    void Update()
    {
        if (dialogueActive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextLine();
            }
        }
    }

    public void StartDialogue()
    {
        currentLine = 0;
        dialogueActive = true;
        dialogueText.gameObject.SetActive(true);
        dilogueBg.SetActive(true);
        playerMovement.enabled = false;
        NextLine();
    }

    public void NextLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
            currentLine++;
        }
        else
        {
            EndDialogue();
            StartCoroutine(ShowUI3Second());
        }
    }

    public void EndDialogue()
    {
        dialogueText.gameObject.SetActive(false);
        dilogueBg.SetActive(false);
        dialogueActive = false;
        playerMovement.enabled = true;
    }

    IEnumerator ShowUI3Second()
    {
        foreach (GameObject uiElement in finishUIElements)
        {
            uiElement.SetActive(true);
            yield return new WaitForSeconds(3);
            uiElement.SetActive(false);
        }

        playerMovement.enabled = true;
    }
}
