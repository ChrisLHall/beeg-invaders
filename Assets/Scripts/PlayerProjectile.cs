using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
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
        rb.velocity = Vector2.up * startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.attachedRigidbody.GetComponent<BasicEnemy>();
        if (null != enemy)
        {
            enemy.HitByProjectile(this);
            Destroy(gameObject); // todo explode
        }
    }
}
