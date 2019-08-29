using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : Interactable
{
    public GameObject dialogueBox;
    public Text dialogueText;
    public string[] dialogue;
    public int currentLine;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            if (dialogueBox.activeInHierarchy && currentLine >= dialogue.Length)
            {
                dialogueBox.SetActive(false);
                currentLine = 0;
            }
            else
            {
                dialogueBox.SetActive(true);
                dialogueText.text = dialogue[currentLine];
                currentLine++;
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
}
