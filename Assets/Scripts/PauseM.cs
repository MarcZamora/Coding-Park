using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseM : MonoBehaviour
{
    // public static bool GameIspaused = false;
    // void Update()
    // {
    //     if (pause.SetActive = true)
    //     {
    //         if (GameIspaused)
    //         {
    //             Resume();
    //         }
    //         else
    //         {
    //             Pause();
    //         }
    //     }
    // }
    public void Resume()
    {
        Time.timeScale = 1f;
        // GameIspaused = false;
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        // GameIspaused = true;
    }
}
