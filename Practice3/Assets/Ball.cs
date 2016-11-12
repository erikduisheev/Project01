using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
    public Vector3 initialImpulse;
    public AudioClip WallSound;
    public AudioClip PaddleSound;
    public AudioClip LostSound;
    private AudioSource audioSrc;
    public static bool b = true;

	void Start () {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
        audioSrc = GetComponent<AudioSource>();
        Console.WriteLine(LostSound.ToString());
    }
    void OnCollisionEnter (Collision col)
    {
        GameObject gameOb = col.gameObject;
        if (gameOb.CompareTag("Walls"))
        {
            audioSrc.PlayOneShot(WallSound);
        }
        else if (gameOb.CompareTag("Player"))
        {
            audioSrc.PlayOneShot(PaddleSound);
        }
        else if (gameOb.CompareTag("Goal"))
        {
            audioSrc.PlayOneShot(LostSound);
        }
    }
	
	void Update () {
	
	}
}
