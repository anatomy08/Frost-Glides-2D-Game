using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOverAgain : MonoBehaviour
{
    public void GameLoop()
    {
        SceneManager.LoadScene(0);
    }
}
