using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryTransition : MonoBehaviour
{
    [Header("Confirmation Object")]
    public GameObject advStory;

    [Space]
    [Header("Load Time")]
    public float waitTime;

    [Space]
    [Header("Scene to Load")]
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LoadScene());
    }

    public IEnumerator LoadScene()
    {
        if (advStory.GetComponent<FadingText>().advanceStory == true)
        {
            yield return new WaitForSeconds(waitTime);
            /*AsyncOperation async = SceneManager.LoadSceneAsync(sceneToLoad);
            while (!async.isDone)
            {
                yield return null;
            }*/
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
