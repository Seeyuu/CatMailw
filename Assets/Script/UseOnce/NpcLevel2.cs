using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcLevel2 : MonoBehaviour
{

    [SerializeField] GameObject npc;
    [SerializeField] GameObject flower;
   // [SerializeField] GameObject blockcollider;
    public bool isPlayerInRange;


    private void Start()
    {

        npc.SetActive(false);
        flower.SetActive(false);
       // blockcollider.SetActive(false);

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
            flower.SetActive(true);
            //blockcollider.SetActive(true);

        }
        else
        {

        }
    }
}
