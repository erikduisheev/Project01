using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private ScoreUI score;
    public ePlayer player;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerExit(Collider other)
    {
        GameObject gameObject = other.gameObject;
        if (gameObject.CompareTag("Ball"))
        {
            GameObject ball = gameObject;

            //if (score.scorePlayerLeft == 11 || score.scorePlayerRight == 11)
                //SceneManager.LoadScene("2");
        }
    }
}