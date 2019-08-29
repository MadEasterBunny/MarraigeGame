using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneTextHandler : MonoBehaviour
{
    private float speed;
    private Vector3 direction;
    public float stopTime;

    public void Initialize(float speed, Vector3 direction)
    {
        this.speed = speed;
        this.direction = direction;
        StartCoroutine(StopText());
    }

    IEnumerator StopText()
    {
        float rate = 1.0f / stopTime;
        float progress = 0.0f;

        while(progress < 1.0f)
        {
            float translation = speed * Time.deltaTime;
            transform.Translate(direction * translation);
            progress += rate * Time.deltaTime;
            yield return null;
        }
    }
}
