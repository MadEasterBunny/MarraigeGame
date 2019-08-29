using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDisplay : Interactable
{
    public DialogueSetup dialogue;

    public GameObject dialogueBox;

    public TextHandler textHandler;

    private int activeLineIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        textHandler = dialogueBox.GetComponent<TextHandler>();

        //textHandler.Speaker = dialogue.characterName;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            if (dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueBox.SetActive(true);
                AdvanceConversation();
                //dialogueText.text = dialogue;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            context.Raise();
            playerInRange = false;
            dialogueBox.SetActive(false);
        }
    }

    void AdvanceConversation()
    {
        if(activeLineIndex < dialogue.messages.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            textHandler.Hide();
            activeLineIndex = 0;
        }
    }

    void DisplayLine()
    {
        Messages message = dialogue.messages[activeLineIndex];
        Character character = message.character;

        /*if(textHandler.SpeakerIs(character))
        {
            SetDialogue(textHandler, message.text);
        }*/
    }

    void SetDialogue(TextHandler activeSpeaker, string text)
    {
        activeSpeaker.Dialogue = text;
        activeSpeaker.Show();
    }
}
