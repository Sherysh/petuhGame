using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    private GameObject _menu;
    private GameObject _gui;
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _menuButton;

    private void Awake()
    {
        _gui = GameObject.Find("GUIPanel");
        _menu = GameObject.Find("MenuPanel");
    }
    void Start()
    {
        _continueButton.onClick.AddListener(Continue);
        _exitButton.onClick.AddListener(Exit);
        _menuButton.onClick.AddListener(MainMenu);
    }

    void Exit()
    {
        Application.Quit();
    }

    void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Continue()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _menu.SetActive(false);
        _gui.SetActive(true);
    }
}
