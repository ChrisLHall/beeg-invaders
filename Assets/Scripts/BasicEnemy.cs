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
        if (Time.time > lastShootTime + SHOOT_INTERVAL)
        {
            lastShootTime = Time.time;
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError("Enemy trigger enter: " + collision.name);
    }
}
