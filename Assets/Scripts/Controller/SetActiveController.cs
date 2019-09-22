using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveController : MonoBehaviour
{
    public GameObject setActiveObject;

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
    }
}
