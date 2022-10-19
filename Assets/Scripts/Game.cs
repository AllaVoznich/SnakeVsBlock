
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public SnakeMovement Movement;

    public Restart Restart;
    public NextLevel NextLevel;

    private const string LevelIndexKey = "LevelIndex";
    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Movement.enabled = false;
        Debug.Log("Game Over!");
        Restart.Setup();
       
    }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Movement.enabled = false;
        Debug.Log("You Won!");
        NextLevel.Setup(); 
        LevelIndex++;

    }

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevelScene()
    {
        LevelIndex++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}