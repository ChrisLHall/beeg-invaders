﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float startSpeed = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 10f);
    }

    private void Start()
    {
        rb.velocity = Vector2.down * startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.attachedRigidbody.GetComponent<Player>();
        if (null != player)
        {
            player.HitByProjectile(this);
            Destroy(gameObject); // todo explode
        }
    }
}
