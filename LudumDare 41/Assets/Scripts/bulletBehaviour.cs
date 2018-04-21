﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour {
    public GameObject bloodHit;

    private Rigidbody2D rb;
    private GameObject bullet;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        bullet = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(bullet.GetComponent<CircleCollider2D>()); // This line is to prevent multiple hits from one bullet

            GameObject HitParticle = (GameObject)Instantiate(bloodHit, transform.position, transform.rotation);

            collision.transform.gameObject.GetComponent<enemyBehaviour>().health -= 1;

            int healthCheck = collision.transform.gameObject.GetComponent<enemyBehaviour>().health;

            if (healthCheck <= 0)
            {
                Destroy(collision.transform.gameObject);
                GameObject deathParticle = (GameObject)Instantiate(bloodHit, transform.position, transform.rotation);
                Destroy(deathParticle, 0.1f);

            }

            Destroy(HitParticle, 0.1f);
            Destroy(bullet);
        }
    }
}
