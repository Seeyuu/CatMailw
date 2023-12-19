using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollar2 : MonoBehaviour
{
    [SerializeField] GameObject collar2;

    public bool isplayerInRange;

    public CheckCollar checkCollar;

    public void Start()
    {
        collar2.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isplayerInRange = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isplayerInRange = false;
    }

    public void Update()
    {
        if (isplayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            collar2.SetActive(false);
            Debug.Log("collar2 found");
            checkCollar.collarcount++;
        }
        else
        {

        }
    }
}
