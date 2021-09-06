using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _optionsButton;
    [SerializeField] private Button _exitButton;

    void Start()
    {
        _startButton.onClick.AddListener(StartGame);
        _optionsButton.onClick.AddListener(Options);
        _exitButton.onClick.AddListener(Exit);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void Options()
    {

    }

    void Exit()
    {
        Application.Quit();
    }

}
