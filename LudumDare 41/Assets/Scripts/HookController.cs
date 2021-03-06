using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookController : MonoBehaviour {

	public GameObject FishSpawner;
	public float HookSpeed = 0.5f;
	private Renderer FishSpawnRd;
	private Vector3 input;
	float leftEdge;
	float rightEdge;

	// Use this for initialization
	void Start () {
		FishSpawnRd = FishSpawner.GetComponent<Renderer>();
		leftEdge = FishSpawner.transform.position.x - FishSpawnRd.bounds.size.x / 2;
		rightEdge = FishSpawner.transform.position.x + FishSpawnRd.bounds.size.x / 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	
		input = new Vector3(Input.GetAxis("Horizontal"),0,0);
		transform.position += input * HookSpeed * Time.deltaTime;



		if (transform.position.x <= leftEdge) {
			transform.position = new Vector2 (leftEdge, transform.position.y);
		} else if(transform.position.x >= rightEdge) {			
				transform.position = new Vector2 (rightEdge, transform.position.y);			
		}
			

	}
}
