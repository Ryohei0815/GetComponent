using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript: MonoBehaviour {

	public float power = 500f;
	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {
		//this.transform.position = new Vector3 (0f, 2f, 0f);
		_rigidbody = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			this._rigidbody.AddForce (Vector3.up * power);
		}
	}
}
