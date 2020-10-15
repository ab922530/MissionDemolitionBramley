using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int[] highscore = new int[4];
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefs.GetInt("HighScore0"));
    }
    void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore0"))
        {
            highscore[0] = PlayerPrefs.GetInt("HighScore0");
        }
        PlayerPrefs.SetInt("HighScore0", highscore[0]);

        if (PlayerPrefs.HasKey("HighScore1"))
        {
            highscore[1] = PlayerPrefs.GetInt("HighScore1");
        }
        PlayerPrefs.SetInt("HighScore1", highscore[1]);

        if (PlayerPrefs.HasKey("HighScore2"))
        {
            highscore[2] = PlayerPrefs.GetInt("HighScore2");
        }
        PlayerPrefs.SetInt("HighScore2", highscore[2]);

        if (PlayerPrefs.HasKey("HighScore3"))
        {
            highscore[3] = PlayerPrefs.GetInt("HighScore3");
        }
        PlayerPrefs.SetInt("HighScore3", highscore[3]);
    }
    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + highscore[MissionDemolition.level];
        if (MissionDemolition.level == 0)
        {
            if ((highscore[0] < PlayerPrefs.GetInt("HighScore0", highscore[0])) || PlayerPrefs.GetInt("HighScore0") == 0)
            {
                PlayerPrefs.SetInt("HighScore0", highscore[0]);
                gt.text = "High Score: " + highscore[MissionDemolition.level];
            }
        }

        if (MissionDemolition.level == 1)
        {
            if ((highscore[1] < PlayerPrefs.GetInt("HighScore1", highscore[1])) || PlayerPrefs.GetInt("HighScore1") == 0)
            {
                PlayerPrefs.SetInt("HighScore1", highscore[1]);
                gt.text = "High Score: " + highscore[MissionDemolition.level];
            }
        }

        if (MissionDemolition.level == 2)
        {
            if ((highscore[2] < PlayerPrefs.GetInt("HighScore2", highscore[2])) || PlayerPrefs.GetInt("HighScore2") == 0)
            {
                PlayerPrefs.SetInt("HighScore2", highscore[2]);
                gt.text = "High Score: " + highscore[MissionDemolition.level];
            }
        }

        if (MissionDemolition.level == 3)
        {
            if ((highscore[3] < PlayerPrefs.GetInt("HighScore3", highscore[3])) || PlayerPrefs.GetInt("HighScore3") == 0)
            {
                PlayerPrefs.SetInt("HighScore3", highscore[3]);
                gt.text = "High Score: " + highscore[MissionDemolition.level];
            }
        }
       
    }
}
