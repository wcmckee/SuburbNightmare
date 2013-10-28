using UnityEngine;
using System.Collections;

public class BlueLaser : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime*15f);
	}
	
	void OnCollisionEnter(Collision collision){
		Destroy(gameObject);
	}
}
