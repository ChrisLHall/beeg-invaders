using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;

    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
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
}
