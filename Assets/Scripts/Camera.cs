using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera: MonoBehaviour {

	public Transform player;
	public float turnSpeed = 1.0f;

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = new Vector3 (player.position.x, player.position.y + 2.0f, player.position.z - 5.0f);
	}

	// Update is called once per frame
	void LateUpdate () {
		offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X")*turnSpeed, Vector3.up) * offset;
		transform.position = player.position + offset;
		transform.LookAt (player.position);
	}
}

