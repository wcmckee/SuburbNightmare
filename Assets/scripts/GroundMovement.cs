using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(3f*Vector3.left*Time.deltaTime);
	}
}
