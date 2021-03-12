using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileForward : MonoBehaviour
{
    public float speed;
    private GameObject targetPosition;
    private GameObject currentPosition;

    private Rigidbody projectile;
    // Start is called before the first frame update
    void Start()
    {
        /*
        targetPosition = GameObject.Find("ProjectileTargetPosition");
        currentPosition = GameObject.Find("ProjectileSpawnPoint");

        Vector3 lookDireaction = (targetPosition.transform.position - currentPosition.transform.position).normalized;
        Debug.Log("Look Direacion :" + lookDireaction);
        */
        projectile = GetComponent<Rigidbody>();
        projectile.AddRelativeForce(Vector3.forward * speed * 50);
        projectile.AddForce(Vector3.up * speed * 20);
        Destroy(this.gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
//