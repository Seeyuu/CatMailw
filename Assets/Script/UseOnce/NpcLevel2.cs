using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcLevel2 : MonoBehaviour
{

    [SerializeField] GameObject npc;
    public bool isPlayerInRange;


    private void Start()
    {

        npc.SetActive(false);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        isPlayerInRange = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isPlayerInRange = false;
    }
    public void Update()
    {

        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            npc.SetActive(true);

        }
        else
        {

        }
    }
}
