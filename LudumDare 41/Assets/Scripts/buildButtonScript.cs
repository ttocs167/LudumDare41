﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildButtonScript : MonoBehaviour
{

    public float gridSize = 1;
    public GameObject towerType;
    public GameObject player ;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
        void Update()
    {

    }

    void OnMouseDown() {
        Debug.Log("Button Clicked: meant to spawn tower");
        GameObject tower = (GameObject)Instantiate(towerType, player.transform.position, transform.rotation);

    }

    
}
