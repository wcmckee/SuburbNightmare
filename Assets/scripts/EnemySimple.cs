using UnityEngine;
using System.Collections;

public class EnemySimple : MonoBehaviour {

	int enemyLives = 3;
	
	bool goingUp = true;
	bool goingDown;
	
	float enemySpeed = 0.2f;
	
	
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
		
	}
	
	void OnCollisionEnter(){
		enemyLives = enemyLives - 1;
	}
}
