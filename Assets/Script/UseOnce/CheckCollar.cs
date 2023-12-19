using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollar : MonoBehaviour
{
    [SerializeField] GameObject goodhouse;
    [SerializeField] GameObject badhouse;
   // [SerializeField] GameObject housedialogue;
    public int collarcount = 0;
    void Start()
    {
        goodhouse.SetActive(false);
        badhouse.SetActive(true);
       // housedialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCollarPoint();
    }

    void UpdateCollarPoint()
    {
        if (collarcount == 3)
        {
            goodhouse.SetActive(true);
            badhouse.SetActive(false);
          
        }
        else
        {
            
        }
    }
}
