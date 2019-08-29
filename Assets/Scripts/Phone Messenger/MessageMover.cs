using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageMover : MonoBehaviour
{
    public Vector3 moveDistance;
    public float speed;
    public GameObject subtitlesBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            MessageMove();
            subtitlesBox.GetComponent<Subtitles>().ShowSubtitles();
        }
    }

    public void MessageMove()
    {
        this.GetComponent<PhoneTextHandler>().Initialize(speed, moveDistance);
        //this.transform.position = this.transform.position + moveDistance;
    }
}
