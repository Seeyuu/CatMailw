using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;

    public static bool isActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("Start conversations : " + messages.Length);
        DisplayMessage();
    }
    void DisplayMessage(){
        Message messageToDiaplay = currentMessages[activeMessage];
        messageText.text = messageToDiaplay.message;

        Actor actorToDisplay = currentActors[messageToDiaplay.actorid];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;
    }
    public void NextMessage(){
        activeMessage++;
        if(activeMessage < currentMessages.Length){
            DisplayMessage();
        }else{
            Debug.Log("Conversation");
            isActive = false;
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && isActive == true){
            NextMessage();
        }
    }
}
