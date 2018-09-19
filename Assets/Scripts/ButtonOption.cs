using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{

    public void MapSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Map1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void Map2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void Map3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void Credits()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
