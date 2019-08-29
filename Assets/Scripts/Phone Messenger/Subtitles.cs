using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    //public GameObject subtitlePanel;
    public string[] subtitles;
    public Text text;
    private int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        if (currentLine >= subtitles.Length)
        {
            currentLine = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowSubtitles()
    {
       text.text = subtitles[currentLine];
        currentLine++;
    }
}
