using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class DialogueSetup : ScriptableObject
{
    //public int npcID;
    public Character characterName;
    public Messages[] messages;
}

[System.Serializable]
public struct Messages
{
    public Character character;

    [TextArea(2, 5)]
    public string text;
    //public Response[] responses;
}

/*[System.Serializable]
public struct Response
{
    public int next;
    [TextArea(2, 5)]
    public string reply;
    public string prereq;
    public string trigger;
}*/