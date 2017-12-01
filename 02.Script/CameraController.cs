using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject targetCamera;
	public GameObject targetObject;

	private Vector3 offset; //카메라와 타겟 사의 거리

	// Use this for initialization
	void Start () {
		offset = targetCamera.transform.position - targetObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		targetCamera.transform.position = offset + targetObject.transform.position;
	}
}
