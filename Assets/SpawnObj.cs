using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour {

	public GameObject[] tiles;

	
	void Start () {
		int randomBlock = Random.Range(0,tiles.Length);	
		Instantiate(tiles[randomBlock], transform.position, Quaternion.identity);
	}
	
	
}
