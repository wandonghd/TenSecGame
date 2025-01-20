using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControllerScript : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "MainScene";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
