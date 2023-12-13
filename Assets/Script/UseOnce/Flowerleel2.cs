using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowerleel2 : MonoBehaviour
{
    
    [SerializeField] GameObject flower;
    [SerializeField] GameObject giveFlower;
    public bool isPlayerInRange;


    private void Start()
    {

       

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
            
            flower.SetActive(false);
            giveFlower.SetActive(true);
        }
        else
        {

        }
    }
}
