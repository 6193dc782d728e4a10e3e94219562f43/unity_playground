using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBtnController : MonoBehaviour
{
    public void GoToPlayScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
