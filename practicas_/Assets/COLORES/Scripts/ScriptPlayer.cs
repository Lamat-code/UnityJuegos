using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPlayer : MonoBehaviour
{
    public Color orangeColor;
    public Color pinkColor;
    public Color purpleColor;
    public Color cyanColor;
    public float verticalForce = 400f;
    public float restartDelay = 1f;
    public ParticleSystem PlayerParticles;

    private string currentColor;

    Rigidbody2D playerRb;
    SpriteRenderer playerSr;

    void Start()
    {

        playerRb = GetComponent<Rigidbody2D>();
        playerSr = GetComponent<SpriteRenderer>();
        ChangeColor();
        
    }


    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
                playerRb.velocity = Vector2.zero;
                playerRb.AddForce(new Vector2(0, verticalForce));
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ColorChanger"))
        {
            ChangeColor();
            Destroy(collision.gameObject);
            return;
        }

            if(collision.gameObject.CompareTag("FinishLine"))
            {
                gameObject.SetActive(false);
                Instantiate(PlayerParticles, transform.position, Quaternion.identity);
                Invoke("LoadNextScene", restartDelay);
                return;
            }

           if(!collision.gameObject.CompareTag(currentColor))
           {
                gameObject.SetActive(false);
                Instantiate(PlayerParticles, transform.position, Quaternion.identity);
                Invoke("RestartScene", restartDelay);
           }
    }

    void LoadNextScene()
    {
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex + 1);
    }

    void RestartScene()
    {
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex);
    }

    
    void ChangeColor()
    {
        int randomNumber = Random.Range(0, 4);
        Debug.Log(randomNumber);

        if(randomNumber == 0)
        {
            playerSr.color = orangeColor;
            currentColor = "Orange";
        }
        else if(randomNumber == 1)
        {
            playerSr.color = purpleColor;
            currentColor = "Purple";
        }
        else if(randomNumber == 2)
        {
            playerSr.color = cyanColor;
            currentColor = "Cyan";
        }
        else if(randomNumber == 3)
        {
            playerSr.color = pinkColor;
            currentColor = "Pink";
        }
    }

}
