using UnityEngine;
using System.Collections;

public class RTSCamera : MonoBehaviour {
	public float horSpeed = 40;
	public float vertSpeed = 40;
	
	void Update() {
		float horizontal = Input.mousePosition.x * horSpeed * Time.deltaTime;
		float vertical = Input.mousePosition.y * vertSpeed * Time.deltaTime;
		
		transform.Translate(Vector3.forward * vertical);
		transform.Translate(Vector3.right * horizontal);		
	}
}