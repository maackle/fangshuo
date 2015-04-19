#pragma strict

private var audioSource : AudioSource;
private var speedThreshold = 0.25;

function Start () {
	audioSource = GetComponent.<AudioSource>();
}

function Update () {
	var body = GetComponent.<Rigidbody2D>();
	var speed = body.velocity.magnitude;
	if (speed > speedThreshold) {
		// audioSource.loop = true;
		audioSource.volume = Mathf.Min(1.0, (speed - speedThreshold)/1.1);
		if (!audioSource.isPlaying) {
			audioSource.Play();
		}
	} else {
		// audioSource.loop = false;
		audioSource.Stop();
	}
}