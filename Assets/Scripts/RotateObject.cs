using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private String objectTag;

    private Transform objectToRotate;
    private void Update()
    {
        if (ReferenceEquals(objectToRotate, null))
            objectToRotate = GameObject.FindGameObjectWithTag(objectTag).transform;
    }

    public void RotateLeft()
    {
        objectToRotate.Rotate(0, 15, 0);
    }

    public void RotateRight()
    {
        objectToRotate.Rotate(0, -15, 0);
    }
}
