using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HintUI : MonoBehaviour
{
    private bool isPaused;
    public GameObject questMenu;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("quest")){
            isPaused = ! isPaused;
            if(isPaused){
                questMenu.SetActive(true);
                Time.timeScale = 0f;
            }else{
                questMenu.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
    public void Resume(){
        isPaused = !isPaused;
    }
}
