using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateGlobe : MonoBehaviour
{
    public Button ButtonUp;
    public Button ButtonDown;
    public Button ButtonLeft;
    public Button ButtonRight;
    // Start is called before the first frame update
    void Start()
    {
        ButtonUp.GetComponent<Button>().onClick.AddListener(RotateUp);
        ButtonDown.GetComponent<Button>().onClick.AddListener(RotateDown);
        ButtonLeft.GetComponent<Button>().onClick.AddListener(RotateLeft);
        ButtonRight.GetComponent<Button>().onClick.AddListener(RotateRight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RotateUp()
    {
        gameObject.transform.GetChild(0).transform.Rotate(15.0f, 0.0f, 0.0f, Space.Self);
    }

    void RotateDown()
    {
        gameObject.transform.GetChild(0).transform.Rotate(-15.0f, 0.0f, 0.0f, Space.Self);
    }

    void RotateLeft()
    {
        gameObject.transform.GetChild(0).transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }

    void RotateRight()
    {
        gameObject.transform.GetChild(0).transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
    }
}
