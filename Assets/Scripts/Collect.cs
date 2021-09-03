using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private GameObject _player;

    void Start()
    {
        _player = GameObject.Find("Petuh");
    }

    private void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == _player.name)
        {
            gameObject.SetActive(false);
            _player.GetComponent<Player>()._timer = 100;
        }

    }
}
