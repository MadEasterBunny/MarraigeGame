using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JapanTransition : MonoBehaviour
{
    [Header("Scene To Load")]
    public string sceneToLoad;

    [Space]
    [Header("Transition Variables")]
    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public float waitTime;

    private void Awake()
    {
        if(fadeInPanel != null)
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(FadeCo());
        }
    }

    private void OnEnable()
    {
        StartCoroutine(FadeCo());
    }

    public IEnumerator FadeCo()
    {
        if(fadeOutPanel != null)
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
