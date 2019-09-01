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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(FadeCo());
        }
    }

    public IEnumerator FadeCo()
    {
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
