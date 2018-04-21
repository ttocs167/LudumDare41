using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildButtonScript : MonoBehaviour
{

    public float gridSize = 1;
    public GameObject towerType;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        Debug.Log("Button Clicked: meant to spawn tower");
        var pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.x = Mathf.Floor(pos.x / gridSize) * (gridSize) + 0.5f * gridSize;
        pos.y = Mathf.Floor(pos.y / gridSize) * (gridSize) + 0.5f * gridSize;
        pos.z = 45;
        pos = Camera.main.ScreenToWorldPoint(pos);

        GameObject tower = (GameObject)Instantiate(towerType, pos, transform.rotation);

    }

    
}
