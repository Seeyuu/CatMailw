using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collar3Count : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isplayerInRange;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isplayerInRange = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isplayerInRange = false;
    }
    void Update()
    {
        if (isplayerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("collar3 collect");
        }
    }
}
