using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerBehaviour : MonoBehaviour
{
    public float range = 20;
    public float damage;
    public float rateOfFire;
    public GameObject bulletType;
    public float bulletSpeed;
    public float rangeTime = 2f;

    private GameObject target;
    private float nextFire = 0.0f;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 heading = (target.transform.position - this.transform.position);
        var distance = heading.magnitude;
        Vector2 lookDirection = heading / distance;

        if (heading.sqrMagnitude < range * range)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + rateOfFire;

                GameObject bullet = (GameObject)Instantiate(bulletType, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody2D>().AddForce(lookDirection * bulletSpeed);

                Destroy(bullet, rangeTime);
            }
        }
    }
}
