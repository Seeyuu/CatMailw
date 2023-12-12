using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollar : MonoBehaviour
{
    [SerializeField] GameObject house;
   // [SerializeField] GameObject housedialogue;
    public int collarcount = 0;
    void Start()
    {
        house.SetActive(false);
       // housedialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCollarPoint();
    }

    void UpdateCollarPoint()
    {
        if (collarcount < 3)
        {
           
          
        }
        else
        {

        }
    }
}
