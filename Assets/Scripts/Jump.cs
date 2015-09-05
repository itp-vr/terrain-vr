using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public Rigidbody rigidbody;
	public VRMoveController vrMoveController;
	public float jumpforce=2000;
	// Use this for initialization
	void Start () {
		if (!rigidbody){
			rigidbody = GetComponent<Rigidbody>();
		}
		if (!vrMoveController){
			vrMoveController = GetComponent<VRMoveController>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Submit") && vrMoveController.onGround){
			rigidbody.AddForce(0,jumpforce,0);
		}
	}
}
