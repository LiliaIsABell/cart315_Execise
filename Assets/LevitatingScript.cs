using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code by A-7r3Dy from https://answers.unity.com/questions/1461782/make-a-levitating-platform-react-to-a-players-jump.html
public class LevitatingScript : MonoBehaviour
{
    public Vector3 startPos;
    public float distance = 2f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = startPos + new Vector3(0.0f, Mathf.Sin(Time.time) * distance, 0.0f);
        

    }





}

