using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    [SerializeField] private String objectTag;

    private GameObject objectToToggle;
    void Update()
    {
        if (ReferenceEquals(objectToToggle, null))
        {
            objectToToggle = GameObject.FindGameObjectWithTag(objectTag);
        }
    }

    public void ToggleObjectActive()
    {
        objectToToggle.SetActive(!objectToToggle.activeSelf);
    } 
}
