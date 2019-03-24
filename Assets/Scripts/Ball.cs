using UnityEngine;
//using System.Collections;

public class Ball : MonoBehaviour {
	
	public Paddle paddle;
	public float speed = 10.0f;
	private bool hasStarted = false;
	private float sq2 = (Mathf.Sqrt(2.0f))/2.0f;
	private Rigidbody2D rb;
	private Vector2 shootVector;
	private Vector3 PaddleToBallVector;
	
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		rb = this.GetComponent<Rigidbody2D>();
		PaddleToBallVector = this.transform.position - paddle.transform.position;
	 	shootVector = new Vector2(Random.Range(-sq2, sq2), 1);
	}
	
	void FixedUpdate () {
	
		if(!hasStarted){
			this.transform.position = paddle.transform.position + PaddleToBallVector;
		}
	
		if(Input.GetKeyDown(KeyCode.Mouse0) && (!hasStarted)){
			rb.velocity = shootVector.normalized * speed;
			hasStarted = true;
		}
			
	}
	
	}
