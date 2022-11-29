using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class camera_sc : MonoBehaviour
{
    public GameObject canvas;

    private bool flag = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (flag)
            {
                Resume();
            }
            else
            {
                canvas.SetActive(true);
                Time.timeScale = 0f;
                flag = true;
            }
        }
    }

    public void Resume()
    {
        canvas.SetActive(false);
        Time.timeScale = 1f;
        flag = false;
    }

    public void Pause()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
