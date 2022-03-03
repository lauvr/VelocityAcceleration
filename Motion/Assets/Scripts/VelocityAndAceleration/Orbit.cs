using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class Orbit : MonoBehaviour {

	[SerializeField]
	GameObject planet;

	[SerializeField]
	Vector3 acceleration;

	[SerializeField]
	[Range(0,1)] float damping = 0.9f;

	Vector3 displacement;

	[SerializeField]
	Vector3 velocity;

	[SerializeField]float xBorder, yBorder;

	public void Update()
	{
		Move();
	}

	public void Move()
	{
		acceleration = planet.transform.position - transform.position;

		velocity += acceleration * Time.deltaTime;

		displacement = velocity * Time.deltaTime;

		transform.position = transform.position + displacement;

		velocity.Draw (transform.position, Color.green);
		transform.position.Draw (Color.red);

		acceleration.Draw (transform.position, Color.blue);
	}


}
