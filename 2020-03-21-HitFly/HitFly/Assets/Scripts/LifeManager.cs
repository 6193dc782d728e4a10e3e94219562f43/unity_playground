using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public UiManager UiManager;
    private bool _isGameOver;
    private bool _isPause;

    private void Start()
    {
        _isGameOver = false;
        _isPause = false;
    }

    public void Pause()
    {
        _isPause = true;
        EnemySpawner enemySpawner = GameObject.Find("_enemySpawner").GetComponent<EnemySpawner>();
        enemySpawner.Pause();
        PlaneController character = GameObject.Find("Character").GetComponent<PlaneController>(); ;
        character.Pause();
    }

    public void Resume()
    {
        _isPause = false;
        EnemySpawner enemySpawner = GameObject.Find("_enemySpawner").GetComponent<EnemySpawner>();
        enemySpawner.Resume();
        PlaneController character = GameObject.Find("Character").GetComponent<PlaneController>(); ;
        character.Resume();
    }

    public void GameOver()
    {
        this.Pause();
        _isGameOver = true;
        UiManager.ShowDeadText();
    }

    public void Update()
    {
        if(_isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                BackToMain();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HotReset();
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.P))
            {
                if (_isPause)
                {
                    this.Resume();
                }
                else
                {
                    this.Pause();
                }
            }
        }
    }

    private void HotReset()
    {
        UiManager.HideDeadText();
        _isGameOver = false;
        EnemySpawner enemySpawner = GameObject.Find("_enemySpawner").GetComponent<EnemySpawner>();
        enemySpawner.HotReset();
        PlaneController character = GameObject.Find("Character").GetComponent<PlaneController>(); ;
        character.HotReset();
    }

    private void BackToMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
