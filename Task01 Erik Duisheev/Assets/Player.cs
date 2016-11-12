using UnityEngine;
using System.Collections;

public enum ePlayer
{
    Left,
    Right
}

public class Player : MonoBehaviour {

    public float InputForceScale = 300.0f;
    public float ForceAppliedToBallScale = 4.0f;
    private Rigidbody rigidBody;
    public ePlayer player;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalAxis = 0f;
        if (player == ePlayer.Left)
        {
            horizontalAxis = Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePlayer.Right)
        {
            horizontalAxis = Input.GetAxisRaw("PlayerRight");
        }
        Vector3 force = new Vector3(0.0f, 0.0f, horizontalAxis) * InputForceScale;
        rigidBody.AddForce(force);
    }

    //public float speed = 15f;
    //public ePlayer player;
    //public float ForceAppliedToBallScale = 4.0f;

    //void Update()
    //{
    //    float inputSpeed = 0f;
    //    if (player == ePlayer.Left)
    //    {
    //        inputSpeed = Input.GetAxisRaw("PlayerLeft");
    //    }
    //    else if (player == ePlayer.Right)
    //    {
    //        inputSpeed = Input.GetAxisRaw("PlayerRight");
    //    }

    //    transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
    //}

    void OnCollisionEnter(Collision other)
    {
        GameObject gamObj = other.gameObject;

        if (gamObj.CompareTag("Ball"))
        {
            //GameObject gamObj = gameObject;
            float shift = gamObj.transform.position.z - transform.position.z;

            Vector3 force = new Vector3(shift, 0.0f, shift) * ForceAppliedToBallScale;
            gamObj.GetComponent<Rigidbody>().AddForce(force);
        }

    }
}
