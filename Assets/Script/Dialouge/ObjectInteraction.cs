using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    //script����ͧui�͹�觢ͧ
    public DialougeManagerTest dialougeManagerTest;
    public bool playerInRange;
    public bool hasEnteredCollider = false;

    public GameObject SendUI;

    void Start()
    {
        SendUI.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && !hasEnteredCollider)
        {

            StartCoroutine(ShowUI2Second());
           
            hasEnteredCollider = true;
        }
        else
        {


        }
    }

    void Interac()
    {

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
        SendUI.SetActive(true);

        yield return new WaitForSeconds(2);

        SendUI.SetActive(false);
        dialougeManagerTest.StartDialogue();
    }
}
