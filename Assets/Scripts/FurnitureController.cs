using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class FurnitureController : MonoBehaviour {

	public AudioClip bumpSound;

	void OnCollisionEnter2D(Collision2D collision) {
		GetComponent<AudioSource>().PlayOneShot(bumpSound, 1.0f);
	}
}
