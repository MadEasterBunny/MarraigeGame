using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeMusicOnEnable : MonoBehaviour
{
    public int fadeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(FadeStart());
    }

    public IEnumerator FadeStart()
    {
        AudioSource audioSource = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioSource>();
        while(audioSource.volume >= 0.01f)
        {
            audioSource.volume -= Time.deltaTime / fadeTime;
            yield return null;
        }

        audioSource.volume = 0;

        audioSource.Stop();
    }
}
