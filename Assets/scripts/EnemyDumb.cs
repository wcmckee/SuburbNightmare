using UnityEngine;
using System.Collections;

public class EnemyDumb : MonoBehaviour {

	int enemyLives = 3;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(enemyLives < 1){
			Destroy(gameObject);
		}
			
	}
	
	void OnCollisionEnter(){
		enemyLives = enemyLives - 1;
	}
}
