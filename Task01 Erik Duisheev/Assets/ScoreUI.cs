using UnityEngine;
using System.Collections;

public class ScoreUI : MonoBehaviour {

    public static int scorePlayerRight;
    public static int scorePlayerLeft;
    public string text;
    public GUIStyle style;
    
	void OnGUI ()
    {
        float x = Screen.width / 2f;
        float y = 30f;
        float width = 100f;
        float height = 20f;
        text = scorePlayerLeft + "     /     " + scorePlayerRight;

        if (scorePlayerLeft >= 11)
        {
            //Application.LoadLevel("2");
            text = scorePlayerLeft + " / " + scorePlayerRight +
                "    - Left Player Won";
        }
        else if (scorePlayerRight >= 11)
        {
            text = scorePlayerLeft + " / " + scorePlayerRight +
                "    - Right Player Won";
        }

        GUI.Label(new Rect(x - (width / 2f), y, width, height), text, style);

    }
}
