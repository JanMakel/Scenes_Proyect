using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scenes : MonoBehaviour
{
 


    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Pause()
    {
        SceneManager.LoadScene("Game_Menu");
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene("Game_over");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
