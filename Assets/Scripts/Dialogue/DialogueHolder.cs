using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : DialogueManager
{
    public string dialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && playerInRange)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                DisplayText(dialogue);
            }
        }
    }
}
