using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerBorder : MonoBehaviour {

    public ePlayer player;
    
    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
        }
    }
}
