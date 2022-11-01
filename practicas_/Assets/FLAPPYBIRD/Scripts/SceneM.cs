using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
  public void Game1()
    {
        SceneManager.LoadScene(1);
    }
    public void Game2()
    {
        SceneManager.LoadScene(2);
    }
    public void Game3()
    {
        SceneManager.LoadScene(3);
    }
}
