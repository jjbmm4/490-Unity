using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Camera camera1;
    public GameObject projectile;
    public Transform FirePosition;
    public float projectileSpeed = 30f;

    public Animator StringOne;
    public Animator StringTwo;
    public Animator Handle;

    private float fireSpeed = 1.5f;
    private float lastShot = 0.0f;
    private float shotDelay = .5f;

    private Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > (lastShot + fireSpeed) && Input.GetButtonDown("Fire1"))
        {
            lastShot = Time.time;
            Debug.Log("Fire In the hole");
            
            ShootProjectile();

        }

    }

    void ShootProjectile()
    {
        StartCoroutine(FireAnimation());
        
 


    }

    IEnumerator FireAnimation()
    {

        Debug.Log("Animation Played");
        StringOne.SetBool("Fire", true);
        StringTwo.SetBool("Fire", true);
        Handle.SetBool("Fire", true);

        yield return new WaitForSeconds(shotDelay);

        StringOne.SetBool("Fire", false);
        StringTwo.SetBool("Fire", false);
        Handle.SetBool("Fire", false);
        Instantiate(projectile, FirePosition.position, FirePosition.rotation);
    }
    /*
    void InstantiateProjectile(Transform firePoint)
    {
        var projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        //projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;
    }
    */



}
