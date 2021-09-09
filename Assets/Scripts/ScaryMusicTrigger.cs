using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryMusicTrigger : MonoBehaviour
{
    private GameObject _player;
    private GameObject _music;
    void Awake()
    {
        _player = GameObject.Find("Petuh");
        _music = GameObject.Find("Scary Music");
    }

    private void Start()
    {
        _music.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == _player.name)
        {
            _music.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == _player.name)
        {
            _music.SetActive(false);
        }
    }
}
