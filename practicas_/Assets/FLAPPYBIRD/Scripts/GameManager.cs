using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int lifes = 3;
    public int currentLifes;
    public TMP_Text textLifes;

    void Start()
    {
        currentLifes = lifes;
    }

    void Update()
    {
        lifes = currentLifes;
        textLifes.text = "Lifes: " + lifes.ToString();

        if(lifes <= 0)
        {
            lifes = 3;
            SceneManager.LoadScene(0);
        }
    }
}
