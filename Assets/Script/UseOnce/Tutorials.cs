using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
    public bool isPlayerInRange;
    [SerializeField] GameObject showdialogue;
    // Start is called before the first frame update
    void Start()
    {
        showdialogue.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        isPlayerInRange = true;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isPlayerInRange = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            showdialogue.SetActive(true);

        }
        else
        {

        }
    }
}
