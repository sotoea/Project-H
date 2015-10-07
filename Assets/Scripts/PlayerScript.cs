using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	float speed = 10;

	float forward;
	bool forwardStop;
	float right;
	bool rightStop;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			if(forward < 1)
				forward += 0.05f;
			transform.GetComponent<Rigidbody>().velocity = new Vector3(right, 0, forward)*speed;
		}
		else if(Input.GetKey(KeyCode.DownArrow)){
			if(forward > -1)
				forward -= 0.05f;
			transform.GetComponent<Rigidbody>().velocity = new Vector3(right, 0, forward)*speed;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			if(right < 1)
				right += 0.05f;
			transform.GetComponent<Rigidbody>().velocity = new Vector3(right, 0,forward)*speed;
		}
		else if(Input.GetKey(KeyCode.LeftArrow)){
			if(right > -1)
				right -= 0.05f;
			transform.GetComponent<Rigidbody>().velocity = new Vector3(right, 0, forward)*speed;
		}

		if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
			forwardStop = true;
		if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
			rightStop = true;

		if(forwardStop){
			if(forward > 0.1){
				forward -= 0.01f;
			}else if(forward < 0.1){
				forward +=0.01f;
			}else{
				forward = 0;
				forwardStop = false;
			}
		}

		if(rightStop){
			if(right > 0.1){
				right -= 0.01f;
			}else if(right < 0.1){
				right +=0.01f;
			}else{
				right = 0;
				rightStop = false;
			}
		}
	}
}
