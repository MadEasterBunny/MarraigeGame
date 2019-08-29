using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenTransition : MonoBehaviour
{
    [Header("SceneToLoad")]
    public string sceneToLoad;

    [Header("FadeScreen")]
    public GameObject fadeIn;
    public GameObject fadeOut;
    public float fadeTime;

    private void Awake()
    {
        GameObject panel = Instantiate(fadeIn, Vector3.zero, Quaternion.identity) as GameObject;
        Destroy(panel, 1);
    }

    public void ChangeScene()
    {
        StartCoroutine(FadeScene());
    }

    IEnumerator FadeScene()
    {
        if(fadeOut != null)
        {
            Instantiate(fadeOut, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(fadeTime);
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneToLoad);
    }
}
