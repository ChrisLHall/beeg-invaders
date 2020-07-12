using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public GameObject bulletPrefab;

    private const float SHOOT_INTERVAL = 2f;
    private float lastShootTime;
    // Start is called before the first frame update
    void Start()
    {
        lastShootTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
