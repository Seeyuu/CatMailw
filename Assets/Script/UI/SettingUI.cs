using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingUI : MonoBehaviour
{
    public GameObject questUI;
    public GameObject tutorialUI;
    public GameObject SettingUi;
    public void QuestUI()
    {
        questUI.SetActive(true);
    }

    public void TutorialUI()
    {
        tutorialUI.SetActive(true);
    }
    public void Setting()
    {
        SettingUi.SetActive(true);
    }
}
