//Basic collision detection checking for two differently named objects
function OnCollisionEnter(theCollision : Collision){
 if(theCollision.gameObject.name == "Wall"){
  Debug.Log("Hit the floor");
 }
}