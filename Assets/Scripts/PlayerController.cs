using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float turnDampening = 0.15f;

    private Vector2 targetDirection;
    private float forwardAngle = -90f;

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
        Transform transform = GetComponent<Transform>();
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(moveHorizontal * speed, moveVertical * speed);
        rigidbody.AddForce(force);
        if (force != Vector2.zero) {
	        float angle = Mathf.Atan2(force.y, force.x) * 180 / Mathf.PI + forwardAngle;
	        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
	        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnDampening);
        }
	}
}
