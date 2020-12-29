using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }*/

    public bool levelOver = false;
    public GameObject CompleteLevelUI;
    public GameObject RetryLevelUI;
    static float secondsToMaxDifficulty = 120f;
    public bool isGameOver = false;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        levelOver = true;
        //Debug.Log("WON THE LEVEL!");
    }

    public void EndGame()
    {
        RetryLevelUI.SetActive(true);
        isGameOver = true;
    }

    public void Restart()
    {
        Invoke("Restarting", 0.5f);
    }

    void Restarting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void GoToMainMenu() {
        SceneManager.LoadScene(0);
    }

    public void NextLevel() {
        Invoke("LoadNextLevel", .5f);
    }

    void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*public static float getDifficultyPercent() {

        float difficultyPercent = Mathf.Clamp01(Time.timeSinceLevelLoad/secondsToMaxDifficulty);

        return difficultyPercent;
    }*/

    public void pauseNUnpauseGame()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }else
        {
            Time.timeScale = 1;
        }
    }

}
