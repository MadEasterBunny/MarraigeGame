using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneMessengerManager : MonoBehaviour
{
    private static PhoneMessengerManager instance;

    public static PhoneMessengerManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<PhoneMessengerManager>();
            }
            return instance;
        }
    }
    public GameObject matthewTextbox;
    public GameObject sakiTextbox;

    public GameObject matthewTextPrefab;
    public GameObject sakiTextPrefab;

    public Text matthewText;
    public Text sakiText;

    private int currentLineMatthew;
    private int currentLineSaki;

    public float speed;
    public Vector3 direction;

    public string[] matthewMessage;
    public string[] sakiMessage;

    public RectTransform canvasTransform;
    public Vector3 textPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLineMatthew >= matthewMessage.Length)
        {
            currentLineMatthew = 0;
        }
        else
        {
            TextActiveMatthew(transform.position);
            currentLineMatthew++;
        }

        if(currentLineSaki >= sakiMessage.Length)
        {
            currentLineSaki = 0;
        }
        else
        {
            TextActiveSaki(transform.position);
            currentLineSaki++;
        }
    }

    public void TextActiveMatthew(Vector3 position)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            GameObject textBoxM = Instantiate(matthewTextbox, position, Quaternion.identity);
            //textBoxM.name = "TextBoxM";
            GameObject textM = (GameObject)Instantiate(matthewTextPrefab, textPosition, Quaternion.identity);
            //textM.name = "textM";

            textBoxM.transform.SetParent(canvasTransform);
            textM.transform.SetParent(canvasTransform);

            textBoxM.GetComponent<RectTransform>().localScale = new Vector3(.75f,.15f,1);
            textM.GetComponent<RectTransform>().localScale = new Vector3(.425f, .425f, 1);

            textBoxM.GetComponent<PhoneTextHandler>().Initialize(speed, direction);
            textM.GetComponent<PhoneTextHandler>().Initialize(speed, direction);
            //GameObject.Find("TextBoxM").GetComponent<PhoneTextHandler>().Initialize(speed, direction);
            //GameObject.Find("textM").GetComponent<PhoneTextHandler>().Initialize(speed, direction);

            matthewText.text = matthewMessage[currentLineMatthew];
        }
    }

    public void TextActiveSaki(Vector3 position)
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject textBoxS = Instantiate(sakiTextbox, position, Quaternion.identity);
            GameObject textS = (GameObject)Instantiate(sakiTextPrefab, textPosition, Quaternion.identity);
 
            textBoxS.transform.SetParent(canvasTransform);
            textS.transform.SetParent(canvasTransform);

            textBoxS.GetComponent<RectTransform>().localScale = new Vector3(.75f, .15f, 1);
            textS.GetComponent<RectTransform>().localScale = new Vector3(.425f, .425f, 1);

            textBoxS.GetComponent<PhoneTextHandler>().Initialize(speed, direction);
            textS.GetComponent<PhoneTextHandler>().Initialize(speed, direction);

            sakiText.text = sakiMessage[currentLineSaki];
        }
    }
}
