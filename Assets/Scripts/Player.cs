using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField]
    private float speed;
    //Vector2 direction;

    private Rigidbody2D rigBody2D;

	// Use this for initialization
	void Start () {
        rigBody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update() {
        //GetInput();
        //Move();

        //Get input from keyboard
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //Prevent diagonal movement
        //if (Mathf.Abs(x) >= Mathf.Abs(y))
        //{
        //    y = 0;
        //}
        //if (Mathf.Abs(y) >= Mathf.Abs(x))
        //{
        //    x = 0;
        //}
        //direction = new Vector2(x, y);

        //Move Player
        //rigBody2D.velocity = new Vector2(x, y) * speed;
        rigBody2D.velocity = new Vector2(x, y) * speed;
    }

    //private void Move()
    //{
    //    transform.Translate(direction*speed*Time.deltaTime);
    //}

    //private void GetInput()
    //{
    //    direction = Vector2.zero;
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        direction += Vector2.up;
    //    }
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        direction += Vector2.down;
    //    }
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        direction += Vector2.left;
    //    }
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        direction += Vector2.right;
    //    }
    //}
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "Stones")  // or if(gameObject.CompareTag("YourWallTag"))
    //    {
    //        GetComponent<Rigidbody>().velocity = Vector2.zero;
    //    }
    //}
}
