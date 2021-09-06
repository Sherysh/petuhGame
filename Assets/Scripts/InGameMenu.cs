using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _menuButton;

    void Start()
    {
        _exitButton.onClick.AddListener(Exit);
        _menuButton.onClick.AddListener(MainMenu);
        //Cursor.lockState = CursorLockMode.None;
    }

    void Exit()
    {
        Application.Quit();
    }

    void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
