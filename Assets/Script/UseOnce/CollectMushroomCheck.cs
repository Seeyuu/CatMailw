using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMushroomCheck : MonoBehaviour
{
    [SerializeField] GameObject givecollarUi;
    [SerializeField] GameObject collar;
    public bool isplayerInRange;
    void Start()
    {
        givecollarUi.SetActive(false);
        collar.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        isplayerInRange = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isplayerInRange = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isplayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            givecollarUi.SetActive(true);
            collar.SetActive(true);
        }
    }
}
