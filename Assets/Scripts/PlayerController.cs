using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed;

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(moveHorizontal * speed, moveVertical * speed);
        rigidbody.AddForce(force);
	}
}
