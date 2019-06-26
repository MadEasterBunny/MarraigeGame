using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMove : MonoBehaviour
{
    public Vector2 cameraChange;
    /*public Vector2 cameraMinChange;
    public Vector2 cameraMaxChange;*/
    public Vector3 playerChange;
    private CameraMovement cam;
    public bool needText;
    public string placeName;
    public GameObject text;
    public Text placeText;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();
        placeText.canvasRenderer.SetAlpha(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            cam.minPosition += cameraChange;
            cam.maxPosition += cameraChange;
            collision.transform.position += playerChange;

            if(needText)
            {
                StartCoroutine(ShowPlaceText());
            }

        }
    }

    public IEnumerator ShowPlaceText()
    {
        text.SetActive(true);
        placeText.text = placeName;
        placeText.CrossFadeAlpha(1, 2, false);
        yield return new WaitForSeconds(4f);
        placeText.CrossFadeAlpha(0, 2, false);
        yield return new WaitForSeconds(2f);
        text.SetActive(false);
        placeText.canvasRenderer.SetAlpha(0.0f);
    }
}
