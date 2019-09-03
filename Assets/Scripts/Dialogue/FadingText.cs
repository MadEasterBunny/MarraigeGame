using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadingText : MonoBehaviour
{
    [Header("Text and Variables")]
    public Text fadingText;
    public Text subtitlesText;
    public GameObject subtitles;
    [TextArea(2, 5)]
    public string[] storyText;
    [TextArea(2, 5)]
    public string[] subtitleText;
    private int currentTextIndex;
    public bool advanceStory;

    [Space]
    [Header("Fade Variables")]
    public float fadingTime;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTextIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        StartCoroutine(FadeText());
    }

    public void AdvanceText()
    {
        if(currentTextIndex <= storyText.Length)
        {
            currentTextIndex++;
        }
    }

    public IEnumerator FadeText()
    {
        while(currentTextIndex <= storyText.Length)
        {
            fadingText.canvasRenderer.SetAlpha(0.0f);
            fadingText.text = storyText[currentTextIndex];
            subtitlesText.text = subtitleText[currentTextIndex];
            fadingText.CrossFadeAlpha(1, fadingTime, false);
            yield return new WaitForSeconds(waitTime);
            subtitles.SetActive(true);
            fadingText.CrossFadeAlpha(0, fadingTime, false);
            yield return new WaitForSeconds(waitTime);
            fadingText.canvasRenderer.SetAlpha(0.0f);
            AdvanceText();
            if (currentTextIndex >= storyText.Length)
            {
                currentTextIndex = 0;
                fadingText.canvasRenderer.SetAlpha(0.0f);
                //yield return new WaitForSeconds(0.2f);
                subtitles.SetActive(false);
                advanceStory = true;
                yield break;
            }
        } 
    }
}
