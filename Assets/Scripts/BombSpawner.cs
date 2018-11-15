using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour{
    public GameObject bomb;
    int numberOfBombs = 1;
    
    public int firePower = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump") && numberOfBombs >= 1)
        {
            Vector2 spawnPos = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
            var newBomb =  Instantiate(bomb, spawnPos, Quaternion.identity) as GameObject;
            newBomb.GetComponent<Bomb>().firePower = firePower;
            numberOfBombs--;
            Invoke("AddBomb", 1f);
        }
	}

    public void AddBomb()
    {
        numberOfBombs++;
    }
}
