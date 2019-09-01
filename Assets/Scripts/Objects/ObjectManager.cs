using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject chair;
    public bool chairActive;

    // Start is called before the first frame update
    void Awake()
    {
        if(chair.activeInHierarchy == false)
        {
            chairActive = true;
            chair.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        OnEnable();
    }

    private void OnEnable()
    {
        if(chairActive == true)
        {
            chairActive = false;
            chair.SetActive(false);
        }
    }
}
