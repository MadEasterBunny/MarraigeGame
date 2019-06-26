using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorType
{
    key,
    enemy,
    button
}

public class Door : Interactable
{
    [Header("Door Variables")]
    public DoorType thisDoorType;
    public bool isOpen;
    public Inventory playerInventory;
    private SpriteRenderer doorSprite;
    public BoxCollider2D doorCollider;

    private void Start()
    {
        doorSprite = GetComponentInParent<SpriteRenderer>();
        //doorCollider = GetComponentInParent<BoxCollider2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(playerInRange && thisDoorType == DoorType.key)
            {
                if(playerInventory.numberOfKeys > 0)
                {
                    playerInventory.numberOfKeys--;
                    Open();
                }
            }
        }
    }

    public void Open()
    {
        doorSprite.enabled = false;
        isOpen = true;
        doorCollider.enabled = false;
    }

    public void Close()
    {

    }

}
