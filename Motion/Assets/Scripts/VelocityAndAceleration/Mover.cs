using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class Mover : MonoBehaviour {
	
	[SerializeField]
	Vector3 acceleration;

	[SerializeField]
	[Range(0,1)] float damping = 0.9f;

	Vector3 displacement;
	Vector3 velocity;
	[SerializeField]float xBorder, yBorder;

	public void Update()
	{
		Move();
		CheckCollision ();
	}

	public void Move()
	{
		velocity += acceleration * Time.deltaTime;

		displacement = velocity * Time.deltaTime;

		transform.position = transform.position + displacement;

		velocity.Draw (transform.position, Color.green);
		transform.position.Draw (Color.red);
	}

	public void CheckCollision(){

		if (transform.position.x >= xBorder || transform.position.x <= -xBorder) {
			velocity.x = velocity.x * -1 * damping;
		}
		if (transform.position.y >= yBorder || transform.position.y <= -yBorder) {
			velocity.y = velocity.y * -1 * damping;
		}


		if (transform.position.x > xBorder ) {
			transform.position = new Vector3(xBorder, transform.position.y) ;
		}
		if (transform.position.x < -xBorder) {
			transform.position = new Vector3(-xBorder, transform.position.y);
		}
		if (transform.position.y > yBorder) {
			transform.position = new Vector3(transform.position.x, yBorder);
		}
		if (transform.position.y < -yBorder) {
			transform.position = new Vector3(transform.position.x, -yBorder);;
		}
	}
}
