var min : int;
var sec : int;
var fraction : int;
var timecount : float;
var starttime : float;
var timeCounter : GUIText;

function Start ()
{
starttime = Time.time;
}

function Update () {
timecount = Time.time - starttime;
min = (timecount/60f);
sec = (timecount % 60f);
fraction = ((timecount * 10) %10);
timeCounter.text = String.Format("{0:00}:{1:00}:{2:00}",min,sec,fraction);
}