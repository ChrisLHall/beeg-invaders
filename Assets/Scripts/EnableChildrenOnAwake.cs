using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableChildrenOnAwake : MonoBehaviour
{
    void Awake()
    {
        foreach (Transform child in transform)
        {
            if (!child.gameObject.activeSelf)
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
