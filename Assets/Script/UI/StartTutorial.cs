using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StartTutorial : MonoBehaviour
{
    public GameObject uiPanel; // Reference to your UI panel

    private void Start()
    {
        // Show the UI panel when the game starts
        //uiPanel.SetActive(true);

        // Call a method to hide the UI panel after 3 seconds
        //Invoke("HideUI", 2f);
    }

    private void HideUI()
    {
        // Hide the UI panel
        //uiPanel.SetActive(false);
    }


}
