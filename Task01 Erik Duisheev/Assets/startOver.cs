using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startOver : MonoBehaviour
{
    public Text text;

    // Use this for initialization
    void Start()
    {
        if (ScoreUI.scorePlayerLeft > ScoreUI.scorePlayerRight)
        {
            text.text = "Left Player Won !!!";
            Ball.b = true;
        }
        else if (ScoreUI.scorePlayerLeft < ScoreUI.scorePlayerRight)
        {
            text.text = "Right Player Won !!!";
            Ball.b = true;
        }
        else if (ScoreUI.scorePlayerLeft == 0 && ScoreUI.scorePlayerRight == 0)
        {
            text.text = "Game is starting!!!!!";
        }
        else
        {
            Ball.b = true;
            text.text = "Draw";
        }
        ScoreUI.scorePlayerLeft = 0;
        ScoreUI.scorePlayerRight = 0;

        StartCoroutine(BlinkTimer());

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
            SceneManager.LoadScene("Main");
    }

    IEnumerator BlinkTimer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main");

    }
}
