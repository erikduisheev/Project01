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
    private timer timer;
    public static bool b = true;

	// Use this for initialization
	void Start () {
        if(b)
        {
            SceneManager.LoadScene("Secondary");
            b = false;
        }
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
        //if (gameOb.CompareTag("Ball"))
        //{
        //    GameObject ball = gameOb;
        //    float shift = 100 + ball.transform.position.x - transform.position.x;
        //    Vector3 force = new Vector3(shift, 0.0f, 0.0f) * 2f;
        //    ball.GetComponent<Rigidbody>().AddForce(force);
        //}
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
