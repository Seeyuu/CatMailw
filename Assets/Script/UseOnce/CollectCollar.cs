using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollar : MonoBehaviour
{
    [SerializeField] GameObject collar1;
    
    public bool isplayerInRange;

    public void Start()
    {
        collar1.SetActive(true);
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
        if(isplayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            collar1.SetActive(false);
            Debug.Log("collar1 found");
        }
        else
        {

        }
    }
}
