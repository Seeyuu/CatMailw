using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideButton : MonoBehaviour
{
    [SerializeField] GameObject QButton;
    [SerializeField] GameObject JButton;
    [SerializeField] GameObject OButton;

    public bool IsQActive = false;
    public bool isJActive = false;
    public bool isOActive = false;
    public void QuestButton()
    {
        IsQActive = !IsQActive;
        if (IsQActive)
        {
            QButton.SetActive(true);
        }
        else
        {
            QButton.SetActive(false);
        }
    }

    public void HowtoplayButton()
    {
        isJActive = !isJActive;
        if (isJActive)
        {
            JButton.SetActive(true);
        }
        else
        {
            JButton.SetActive(false);
        }


    }

    public void SettingButton()
    {
        isOActive = !isOActive;

        if (isOActive)
        {
            OButton.SetActive(true);
        }
        else
        {
            OButton.SetActive(false);
        }
    }
}
