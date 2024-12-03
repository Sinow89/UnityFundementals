using System;
using UnityEngine;

public class SampleScrip : MonoBehaviour
{
    void Start()
    {
        Debug.LogWarning("START THIS CALLED");
    }

    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    private void OnDisable()
    {
        Debug.Log("Disabled");
    }
}
