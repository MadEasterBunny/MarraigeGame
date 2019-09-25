using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFlowchart : MonoBehaviour
{
    public GameObject flowChart;
    public GameObject sceneChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            flowChart.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            sceneChange.SetActive(true);
        }
    }
}
