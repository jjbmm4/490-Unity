using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(this, 2f);
    }


    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed * Time.deltaTime;
    }
}
