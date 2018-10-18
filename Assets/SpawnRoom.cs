using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoom : MonoBehaviour {
public LayerMask whatIsRoom;
public LevelGeneration LevelGen;
	void Update () {
		Collider2D roomDetection = Physics2D.OverlapCircle(transform.position,1, whatIsRoom);
		if(roomDetection == null && LevelGen.stopGeneration == true){
			//spawn random room
			int rand = Random.Range(0, LevelGen.rooms.Length);
			Instantiate(LevelGen.rooms[rand], transform.position, Quaternion.identity);
		}
	
	
	}
}
