using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceText : MonoBehaviour
{
    public string placeName;
    public GameObject text;
    public Text placeText;

    public string subText;
    public GameObject subtitlesTextbox;
    public Text subtitlesText;

    public float waitTime;
    public float waitTimeAlpha;
    public float waitTimeOpaque;

    private void Awake()
    {
        if (placeText.CompareTag("Ending"))
        {
            placeText.canvasRenderer.SetAlpha(0.0f);
            //placeText.CrossFadeAlpha(0, 0, false);
        }
    }

    private void OnEnable()
    {
        StartCoroutine(ShowPlaceText());
        StartCoroutine(Subtitles());
    }

    public IEnumerator ShowPlaceText()
    {
        if(placeText.CompareTag("Ending"))
        {
            text.SetActive(true);
            placeText.text = placeName;
            yield return new WaitForSeconds(waitTimeAlpha);
            placeText.CrossFadeAlpha(1, waitTime, false);
            yield return new WaitForSeconds(waitTimeOpaque);
            placeText.CrossFadeAlpha(0, waitTime, false);
            yield return new WaitForSeconds(waitTime);
            text.SetActive(false);
            placeText.canvasRenderer.SetAlpha(0.0f);
        }
        else
        {
            text.SetActive(true);
            placeText.text = placeName;
            placeText.CrossFadeAlpha(1, 2, false);
            yield return new WaitForSeconds(2f);
            placeText.CrossFadeAlpha(0, 2, false);
            yield return new WaitForSeconds(2f);
            text.SetActive(false);
            placeText.canvasRenderer.SetAlpha(0.0f);
        }

    }

    public IEnumerator Subtitles()
    {
        subtitlesTextbox.SetActive(true);
        subtitlesText.text = subText;
        yield return new WaitForSeconds(4f);
        subtitlesTextbox.SetActive(false);
    }
}
