using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ui_sc : MonoBehaviour
{
    public Text text;
    public GameObject Coin;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        score = PlayerPrefs.GetInt("score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score = " + score.ToString("0");
        PlayerPrefs.SetInt("score", score);
    }
}
