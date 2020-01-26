using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private float speed = 20.0f;
	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().AddForce((Vector3.forward /* + Vector3.right */) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
