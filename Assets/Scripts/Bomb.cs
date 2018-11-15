using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public int firePower;
    public float fuse;

	// Use this for initialization
	void Start () {
        Invoke("Explode", fuse);
	}
	
	void Explode() {
        Debug.Log("BOOM " + firePower);
        Destroy(gameObject);
	}

    public void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
