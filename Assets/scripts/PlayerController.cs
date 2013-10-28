using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	float moveConst = 200f;
	
	int playerLives = 3;
	int playerScore = 0;
	
	public Rigidbody laser;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame	
	void Update () {
		gameObject.rigidbody.AddForce(Input.GetAxis("Horizontal")*Time.deltaTime * moveConst, 
										Input.GetAxis("Vertical")*Time.deltaTime * moveConst, 0);
		
		if(Input.GetButtonDown("Fire")){
			Object tempBullet;
			tempBullet = Instantiate(laser, transform.position + new Vector3(1.2f, 0,0), Quaternion.Euler(0,0,-90f));
		}
	}
	
	void OnGUI(){
		GUI.Box(new Rect(5,5,100,25), "Lives: " + playerLives);
		GUI.Box(new Rect(5,35,100,25), "Score: " + playerScore);
	}
}
