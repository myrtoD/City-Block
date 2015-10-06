using UnityEngine;
using System.Collections;

public class screenShaker : MonoBehaviour {

	public float shakeAmmount = 2f;
	public float shakeTime = 1.5f;
	
	private bool isShaking = false;
	private Vector3 originalLocation;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F)) {
			StartCoroutine("shakeScreen");
		}
		if (isShaking) {
			transform.position = originalLocation + Random.insideUnitSphere * shakeAmmount * Time.deltaTime;
		}
	}
	
	IEnumerator shakeScreen() {
		isShaking = true;
		originalLocation = transform.position;
		yield return new WaitForSeconds(shakeTime);
		isShaking = false;
	}
}