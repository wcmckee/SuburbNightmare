using UnityEngine;
using System.Collections;

public class RedLaser : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 20f*Time.deltaTime,0);
	}
	
	void OnCollisionEnter(Collision collision){
		Destroy(gameObject);
	}
}
