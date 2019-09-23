using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveController : MonoBehaviour
{
    public GameObject setActiveObject;
    public GameObject setActiveObject2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            setActiveObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            setActiveObject.SetActive(false);
            setActiveObject2.SetActive(true);
        }
    }
}
