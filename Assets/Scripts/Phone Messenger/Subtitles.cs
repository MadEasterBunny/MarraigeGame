using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    public GameObject subtitlePanel;
    public string[] subtitles;
    public Text text;
    public int currentLine = 0;

    private void Start()
    {
        currentLine = 0;
    }

    void Update()
    {
        ShowSubtitles();
    }

    public void AdvanceConversation()
    {
        if (currentLine <= subtitles.Length)
        {
            //ShowSubtitles();
            currentLine += 1;
        }

        if (currentLine == subtitles.Length)
        {
           subtitlePanel.SetActive(false);
        }
    }

    public void ShowSubtitles()
    {
        if(Input.GetMouseButtonDown(0))
        {
            subtitlePanel.SetActive(true);
            text.text = subtitles[currentLine];
            AdvanceConversation();
        }
        /*if(Input.GetKeyDown(KeyCode.E))
        {
            subtitlePanel.SetActive(true);
            text.text = subtitles[currentLine];
            AdvanceConversation();
        }*/
    }
}
