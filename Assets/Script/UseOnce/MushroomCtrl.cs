using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCtrl : MonoBehaviour
{
    [SerializeField] GameObject shroom;
    public bool isplayerInRange;
    void Start()
    {
        shroom.SetActive(false);
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
            shroom.SetActive(true);
        }
    }


}
