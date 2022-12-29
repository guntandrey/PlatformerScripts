using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float seconds = 30;
    public int minutes = 6;

    void Update()
    {
        if (seconds > 0)
        {
            seconds -= Time.deltaTime;
        }
        else if (minutes > 0)
        {
            minutes -= 1;
            seconds += 59;
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
