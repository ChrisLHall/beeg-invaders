using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager inst { get; private set; }

    public int Wave { get; private set; } = 1;

    private void Awake()
    {
        inst = this;
    }
}
