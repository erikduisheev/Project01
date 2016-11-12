using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
    public Vector3 initialImpulse;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }
	void Update () {
	
	}
}
