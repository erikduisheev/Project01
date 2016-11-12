using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float time = 60;
    public Text timerText;
    //public GUIStyle style;
    //private ScoreUI score;
    //private int left;
    //private int right;
    //private Ball ball;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = string.Format("{0:00}:{1:00}", time / 60, time % 60);

        if (time < 0)
        {
            SceneManager.LoadScene("Secondary");
        }
    }


    // Update is called once per frame
    //    void Update()
    //    {
    //        time -= Time.deltaTime;
    //        score = GetComponent<ScoreUI>();
    //        left = score.scorePlayerLeft;
    //        right = score.scorePlayerRight;
    //        //timerText = string.Format("{0:00}:{1:00}", time / 60, time % 60);
    //        //timerText = time.ToString();

    //        ball = GetComponent<Ball>();
    //        if (time < 0)
    //        {
    //            ball.transform.position = new Vector3(0f, -3f, 0f);
    //            Destroy(ball);
    //        }

    //    }

    //    void OnGUI()
    //    {
    //        float x = Screen.width / 2f;
    //        float y = Screen.height - 80f;
    //        float width = 200f;
    //        float height = 20f;
    //        timerText = string.Format("{0:00}:{1:00}", time / 60, time % 60);

    //        if (time < 0)
    //        {
    //            timerText = ("Time is up");
    //            if (left > right)
    //            {
    //                timerText = "Time is up. Left Player Won!";
    //            }
    //            if (left < right)
    //            {
    //                timerText = "Time is up. Right Player Won!";
    //            }
    //            if (left == right)
    //            {
    //                timerText = "Time is up. Draw!";
    //            }
    //        }

    //        GUI.Label(new Rect(x - (width / 2f), y, width, height), timerText, style);
    //    }
}
