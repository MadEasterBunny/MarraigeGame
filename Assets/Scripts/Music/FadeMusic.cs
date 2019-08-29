using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FadeMusic : MonoBehaviour
{
    //public AudioMixerSnapshot fadeMusic;
    //public AudioSource stingSource;
    //public float bpm = 128f;

    //private float m_TransitionIn;
    //private float m_TransitionOut;
    //private float m_QuarterNote;

    public int startFadeTime;

    // Start is called before the first frame update
    /*void Start()
    {
        m_QuarterNote = 60 / bpm;
        m_TransitionIn = m_QuarterNote;
        m_TransitionOut = m_QuarterNote * 32;
    }*/

    // Update is called once per frame
    void Update()
    {
        //PlayMusic();
    }

    /*public void PlayMusic()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            fadeMusic.TransitionTo(m_TransitionOut);
        }
    }*/

    private void OnEnable()
    {
        StartCoroutine(FadeMusicOut());
        //fadeMusic.TransitionTo(m_TransitionOut);
    }

    public IEnumerator FadeMusicOut()
    {
        AudioSource audioMusic = GameObject.FindGameObjectWithTag("AudioController").GetComponent<AudioSource>();
        while(audioMusic.volume > 0.01f)
        {
            audioMusic.volume -= Time.deltaTime / startFadeTime;
            yield return null;
        }

        audioMusic.volume = 0;

        audioMusic.Stop();
        //fadeMusic.TransitionTo(m_TransitionIn);
        //PlayMusic();
        //yield return new WaitForSeconds(startFadeTime);
        //fadeMusic.TransitionTo(m_TransitionOut);
    }

    /*public void PlayMusic()
    {
        stingSource.Play();
    }*/
}
