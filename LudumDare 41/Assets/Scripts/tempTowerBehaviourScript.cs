using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempTowerBehaviourScript : MonoBehaviour {

    private GameObject self;
    public float gridSize = 1;
    public GameObject towerType;
    public float spawnTime;
    public GameObject player;


	// Use this for initialization
	void Start () {
        self = this.gameObject;
        spawnTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        
        var pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.x = Mathf.Floor(pos.x / gridSize) * (gridSize) + 0.5f * gridSize;
        pos.y = Mathf.Floor(pos.y / gridSize) * (gridSize) + 0.5f * gridSize;
        pos.z = 45;
        transform.position = pos;

        if (Input.GetMouseButtonDown(0) & Time.time > spawnTime + 0.2f)
        {
            GameObject tower = (GameObject)Instantiate(towerType, transform.position, transform.rotation);
            Debug.Log("mouse clicked: meant to place tower");
            Debug.Log((Time.time - spawnTime).ToString());
            spawnTime = Time.time;
            Destroy(self);
            
        }

    }


}


