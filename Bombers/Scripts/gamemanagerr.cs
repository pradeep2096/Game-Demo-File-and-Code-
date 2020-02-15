using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanagerr : MonoBehaviour
{
    public static int health;
    public GameObject gameover;
    public GameObject PauseMenu;
    public GameObject nextlevel;
    public GameObject player,bubble;
    public GameObject ShieldButton;
    Scene ActiveScene;
    int PowerUpCount;
    

    // Use this for initialization
    void Start()
    {
        ActiveScene = SceneManager.GetActiveScene();
        health = 100;
        PowerUpCount = 0;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            GameOver();
        }
        if(PowerUpCount>2)
        {
            ShieldButton.SetActive(false);
        }
    }
    void GameOver()
    {
        health = 0;
        gameover.SetActive(true);
        Destroy(player);
        Time.timeScale = 0f;
    }
    public void pause()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
        GameObject.Find("Canvas").GetComponent<AudioSource>().Play();
    }
    public void finish()
    {
        nextlevel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void NextLevelButtonClick()
    {
        SceneManager.LoadScene(ActiveScene.buildIndex+1);
        Time.timeScale = 1f;
        GameObject.Find("Canvas").GetComponent<AudioSource>().Play();

    }
    public void Retry()
    {
        SceneManager.LoadScene(ActiveScene.name);
        Time.timeScale = 1f;
        GameObject.Find("Canvas").GetComponent<AudioSource>().Play();

    }
    public void Resume()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        GameObject.Find("Canvas").GetComponent<AudioSource>().Play();

    }
    public void Home()
    {
        SceneManager.LoadScene(3);
        GameObject.Find("Canvas").GetComponent<AudioSource>().Play();

    }
    public void ShieldActive()
    {
        PowerUpCount += 1;
        bubble.SetActive(true);
        
        StartCoroutine(delay());
        
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(5f);
       GameObject.Find("BubbleIngame").SetActive(false);
    }
    public void play()
    {
        SceneManager.LoadScene(0);
        GameObject.Find("Canvas").GetComponent<AudioSource>().Play();

    }
    public void exit()
    {
        Application.Quit();
        GameObject.Find("Canvas").GetComponent<AudioSource>().Play();

    }
}
