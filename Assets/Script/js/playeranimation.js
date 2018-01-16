#pragma strict

function Start () {
	GetComponent.<Animation>().wrapMode = WrapMode.Loop; // set all animation to loop
	GetComponent.<Animation>()["Jump"].wrapMode = WrapMode.Once; //except those that get specified
	GetComponent.<Animation>()["Run"].wrapMode = WrapMode.Once; //like this

	//layering,so the animation will not affect each other
	GetComponent.<Animation>()["Run"].layer = 1;
	GetComponent.<Animation>()["Jump"].layer = 2;

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
}
