using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtitlesDisplay : MonoBehaviour
{
    public GameObject subtitlesBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplaySubtitles();
    }

    public void DisplaySubtitles()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            subtitlesBox.GetComponent<Subtitles>().ShowSubtitles();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            subtitlesBox.SetActive(false);
        }
    }
}
