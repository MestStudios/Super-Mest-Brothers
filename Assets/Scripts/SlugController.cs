using UnityEngine;
using System.Collections;

public class SlugController : MonoBehaviour {
	private float speed = 5f;
	private float currentLerpTime;
	private float patrolDistance = 1f;
	private Vector3 startPos;
	private Vector3 endPos;
	private Animator animator;

	protected void Start() {
		startPos = transform.position;
		endPos = transform.position - new Vector3(1f, 0f, 0f) * patrolDistance;
		currentLerpTime = 0f;
		animator = GetComponent<Animator> ();
	}
	
	protected void Update() {
		animator.SetFloat ("movementX", startPos.x - endPos.x);
		currentLerpTime += Time.deltaTime;
		if (currentLerpTime > speed) {
			currentLerpTime = speed;
		}
		float perc = currentLerpTime / speed;
		transform.position = Vector3.Lerp(startPos, endPos, perc);

		if (currentLerpTime == speed) {
			Vector3 swap = startPos;
			startPos = endPos;
			endPos = swap;
			currentLerpTime = 0f;
		}

	}
}
