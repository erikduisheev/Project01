using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerBorder : MonoBehaviour {

    public ePlayer player;
    public timer timer;
    
    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);

            if (player == ePlayer.Right) ScoreUI.scorePlayerLeft++;
            else if (player == ePlayer.Left) ScoreUI.scorePlayerRight++;

            if (ScoreUI.scorePlayerLeft >= 11 || ScoreUI.scorePlayerRight >= 11)
            {
                SceneManager.LoadScene("Secondary");
                ball.transform.position = new Vector3(0f, -3f, 0f);
                Destroy(ball);
            }
        }
    }

}
