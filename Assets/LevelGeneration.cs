using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour {

	public Transform[] StartPositions;
	public GameObject[] rooms;

	private int direction;

	public float moveAmount;

	private float timeBtwRoom;
	public float startTimeBtwRoom = 0.25f;


	private void Start() {
		int randStartPos = Random.Range(0, StartPositions.Length);
		transform.position = StartPositions[randStartPos].position;
		Instantiate(rooms[0], transform.position, Quaternion.identity);
	
	
		direction = Random.Range(1,6);


	
	
	}

	private void Update() {
		if(timeBtwRoom <= 0){
			Move();
			timeBtwRoom = startTimeBtwRoom;
		} else {
			timeBtwRoom -= Time.deltaTime;
		}
	}

	private void Move(){
		if(direction == 1 || direction == 2){
			Vector2 newPos = new Vector2(transform.position.x + moveAmount, transform.position.y);
			transform.position = newPos;
		} else if(direction == 3 || direction == 4){
			Vector2 newPos = new Vector2(transform.position.x - moveAmount, transform.position.y);
			transform.position = newPos;
		} else if(direction == 5){
			Vector2 newPos = new Vector2(transform.position.x, transform.position.y - moveAmount);
			transform.position = newPos;
		}

		Instantiate(rooms[0], transform.position, Quaternion.identity);
		direction = Random.Range(1, 6);
	}
}
