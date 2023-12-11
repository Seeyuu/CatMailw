using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject bird;
    public bool isPlayerInRange;


    private void Start()
    {
        
        wall.SetActive(true);
        bird.SetActive(true);

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
            wall.SetActive(false);
            bird.SetActive(false);

        }
        else
        {

        }
    }
}
