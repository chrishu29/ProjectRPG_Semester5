#pragma strict

function Start () {
	GetComponent.<Animation>().wrapMode = WrapMode.Loop; // set all animation to loop
	GetComponent.<Animation>()["Jump"].wrapMode = WrapMode.Once; //except those that get specified

	//layering,so the animation will not affect each other
	GetComponent.<Animation>()["Run"].layer = 1;
	GetComponent.<Animation>()["Jump"].layer = 2;
	GetComponent.<Animation>()["Attack"].layer=3;

	//optional. in case you forgot to disable the "play automatically"
	GetComponent.<Animation>().Stop();
}

function Update () {
	if (Input.GetAxis("Vertical") > 0.01)
      GetComponent.<Animation>().CrossFade ("Walk");
   	else
      GetComponent.<Animation>().CrossFade ("idle");


    if(Input.GetKeyDown(KeyCode.Space)) //jumping animation
    	GetComponent.<Animation>().CrossFade("Jump");
    if(Input.GetButtonDown("Fire1")){ //attack animation
    	GetComponent.<Animation>().CrossFade("Attack");
    }
    if(Input.GetKey(KeyCode.LeftShift)) //running animation
    	GetComponent.<Animation>().CrossFade("Run");
    else
    	GetComponent.<Animation>().Stop("Run"); 
    	//this is a bad stop animation,i dont know what code to use to stop run animation
}
