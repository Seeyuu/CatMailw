using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField] GameObject mushroom;
    [SerializeField] GameObject collectUI;
    public bool isplayerInRange;
    void Start()
    {
        collectUI.SetActive(false);
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
        if(isplayerInRange && Input.GetKeyDown(KeyCode.E)){
            mushroom.SetActive(false);
            collectUI.SetActive(true);
        }
    }
}
