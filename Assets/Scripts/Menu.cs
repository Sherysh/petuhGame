using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _optionsButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Slider _masterVolume;
    public AudioMixer masterMixer;

    void Start()
    {
        _startButton.onClick.AddListener(StartGame);
        _optionsButton.onClick.AddListener(Options);
        _exitButton.onClick.AddListener(Exit);
        _masterVolume.onValueChanged.AddListener((float value) => { SetSound(value * 50); });
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

    void SetSound(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
    }

}
