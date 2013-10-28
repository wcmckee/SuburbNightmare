using UnityEngine;
using System.Collections;

public class EnemySimpleShooter : MonoBehaviour {

	int enemyLives = 3;
	
	bool goingUp = true;
	bool goingDown;
	
	float enemySpeed = 0.01f;
	
	public Rigidbody laser;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(enemyLives < 1){
			Destroy(gameObject);
		}
		
		if(goingUp){
			transform.Translate(0, enemySpeed*Time.deltaTime, 0);
		}
		
		if(goingDown){
			transform.Translate(0, -enemySpeed*Time.deltaTime, 0);
		}
		
		if(transform.position.y > 5){
			goingUp = false;
			goingDown = true;
		}
		
		if(transform.position.y < -5){
			goingUp = true;
			goingDown = false;
		}
		
		
		if(Random.Range(0, 50)%50 == 0){
			Object tempBullet;
			tempBullet = Instantiate(laser, transform.position - new Vector3(1.5f, 0,0), Quaternion.Euler(0,0,90f));
		}
		

		
	}
	
	void OnCollisionEnter(){
		enemyLives = enemyLives - 1;
	}
}
