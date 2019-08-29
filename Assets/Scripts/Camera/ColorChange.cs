using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Camera cam;
    public float cycleSeconds = 0.5f;

    // Start is called before the first frame update
    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.backgroundColor = Color.HSVToRGB(Mathf.Repeat(Time.time / cycleSeconds, 1f), 0.3f, 0.7f);
    }
}
