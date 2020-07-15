using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player inst { get; private set; } // TODO 2-player

    public float moveSpeed = 3f;

    public GameObject bulletPrefab;

    public int Health { get; private set; } = 1; // ????

    private void Awake()
    {
        inst = this;
    }

    void Update()
    {
        var pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.position = pos;

        if (Input.GetButtonDown("Fire1"))
        {
            // todo pool
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.LogError("Player trigger enter: " + collision.name);
    }
}
