using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Saki'sHouseInterior2")
        {
            anim.SetBool("isDrinking", true);
        }
        else
        {
            anim.SetBool("isDrinking", false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
