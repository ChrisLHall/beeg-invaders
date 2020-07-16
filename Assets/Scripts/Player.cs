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
        pos.x = Mathf.Clamp(pos.x, GameBounds.inst.Min.x, GameBounds.inst.Max.x);
        transform.position = pos;

        if (Input.GetButtonDown("Fire1"))
        {
            // todo pool
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }

    public void HitByProjectile(EnemyProjectile proj)
    {
        // TODO?
        Health -= 1;
    }
}
