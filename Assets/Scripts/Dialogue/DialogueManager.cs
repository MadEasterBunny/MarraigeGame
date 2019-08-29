using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : Interactable
{
    public GameObject dialogueBox;
    public Text text;

    public bool isActive;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive && Input.GetKeyDown(KeyCode.E))
        {
            dialogueBox.SetActive(false);
            isActive = false;
        }
    }

    public void DisplayText(string dialogue)
    {
        isActive = true;
        dialogueBox.SetActive(true);
        text.text = dialogue;
    }
}
