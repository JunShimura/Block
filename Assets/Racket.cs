using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

    private float accel = 1000.0f;
    private Vector3 inputVector = new Vector3();
    private Rigidbody rig;
    // Use this for initialization
	void Start () {
        inputVector = Vector3.zero;
        rig = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        inputVector = Vector3.right * Input.GetAxisRaw("Horizontal") * accel;
	
	}
    void FixedUpdate()
    {
        rig.AddForce(inputVector, ForceMode.Impulse);
    }
}
