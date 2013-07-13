var teleportTo : Transform;
 
function OnCollisionEnter (col : Collision) {
    col.transform.position = teleportTo.position;	
}