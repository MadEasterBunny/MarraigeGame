using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassroomDialogue : MonoBehaviour
{
    public Text studentText1;
    public Text studentText2;
    public Text studentText3;
    public Text studentText4;
    public Text studentText5;
    public Text teacherText;
    public GameObject studentBubble;
    public GameObject teacherBubble;

    public string[] studentT;
    public string[] teacherT;

    public int activeLineIndexStudent = 0;
    public int activeLineIndexTeacher = 0;

    public bool teacherTalk = true;

    private void Start()
    {
        //studentText = Text.FindObjectsOfType<Text>();
    }

    void Update()
    {
        DisplayText();
    }

    public void AdvanceDialogueStudent()
    {
        if(activeLineIndexStudent <= studentT.Length)
        {
            DisplayText();
            activeLineIndexStudent += 1;
        }

        if(activeLineIndexStudent == studentT.Length)
        {
            activeLineIndexStudent = 0;
        }
    }

    public void AdvanceDialogueTeacher()
    {
        if (activeLineIndexTeacher <= teacherT.Length)
        {
            DisplayText();
            activeLineIndexTeacher += 1;
        }
        
        if(activeLineIndexTeacher == teacherT.Length)
        {
            activeLineIndexTeacher = 0;
        }
    }

    public void DisplayText()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(teacherTalk == true)
            {
                studentBubble.SetActive(false);
                teacherBubble.SetActive(true);
                teacherText.text = teacherT[activeLineIndexTeacher];
                teacherTalk = false;
                AdvanceDialogueTeacher();
            }
        }
        else
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                if (teacherTalk == false)
                {
                    teacherBubble.SetActive(false);
                    studentBubble.SetActive(true);
                    //studentBubble.GetComponentInChildren<Text>().text = studentT[activeLineIndexStudent];
                    studentText1.text = studentT[activeLineIndexStudent];
                    studentText2.text = studentT[activeLineIndexStudent];
                    studentText3.text = studentT[activeLineIndexStudent];
                    studentText4.text = studentT[activeLineIndexStudent];
                    studentText5.text = studentT[activeLineIndexStudent];
                    teacherTalk = true;
                    AdvanceDialogueStudent();
                }
            }

        }
    }
}
