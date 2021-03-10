using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject player;
    private float speed = 10.0f;
    public float lockX;
    public float lockZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        direction.y = 0;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, speed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
        transform.rotation = Quaternion.Euler(lockX, transform.rotation.eulerAngles.y, lockZ);
    }
}
