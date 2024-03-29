﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : PowerUp
{
    public FloatValue playerHealth;
    public FloatValue heartContainers;
    public float amountToIncrease;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            playerHealth.RunTimeValue += amountToIncrease;
            if(playerHealth.initialValue > heartContainers.RunTimeValue * 2f)
            {
                playerHealth.initialValue = heartContainers.RunTimeValue * 2f;
            }
            powerUpSignal.Raise();
            Destroy(this.gameObject);
        }
    }
}
