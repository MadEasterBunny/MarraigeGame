using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetKeyDownTransition : MonoBehaviour
{
    [Header("Scene To Load")]
    public string sceneToLoad;

    [Space]
    [Header("Transition Variables")]
    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public float waitTime;

    [Space]
    [Header("Audio Controller")]
    public GameObject audioController;

    [Space]
    [Header("Fade Variables")]
    public float startSceneTransition;
    public float startMusicFade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnEnable()
    {
        StartCoroutine(FadeCo());
    }

    public IEnumerator FadeCo()
    {
        yield return new WaitForSeconds(startMusicFade);
        audioController.gameObject.GetComponent<FadeMusic>().MusicStop();
        yield return new WaitForSeconds(startSceneTransition);
        if (fadeOutPanel != null)
        {
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(waitTime);
        AsyncOperation asynOp = SceneManager.LoadSceneAsync(sceneToLoad);
        while (asynOp.isDone)
        {
            yield return null;
        }
    }
}
