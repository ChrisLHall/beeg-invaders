using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public static MainUI inst { get; private set; }

    public Text healthText;
    public Text waveText;

    private void Awake()
    {
        inst = this;
    }

    private void Update()
    {
        healthText.text = "Health: " + Player.inst.Health;
        waveText.text = "Wave: " + WaveManager.inst.Wave;
    }
}
