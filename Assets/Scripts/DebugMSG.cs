using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugMSG : MonoBehaviour
{
    [SerializeField] private string message;
    [SerializeField] private Text _text;
    [SerializeField] private Transform touchVisualize;
    
    void Start()
    {
        _text.text = message;
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            touchVisualize.position = touchPosition;
            
            _text.text = touchPosition.ToString();
        }
    }
}
