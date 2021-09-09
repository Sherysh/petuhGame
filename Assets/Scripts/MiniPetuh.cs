using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPetuh : MonoBehaviour
{
    private GameObject _player;
    private GameObject _redLight;
    private GameObject _greenLight;
    private Vector3 _direction;
    //private float _distance;
    [SerializeField] private float _speed;

    private void Awake()
    {
        _player = GameObject.Find("Petuh");
        _redLight = GameObject.Find("red Light");
        _greenLight = GameObject.Find("green Light");
        _direction = new Vector3(0, 0, 1);
    }

    private void Start()
    {
        _greenLight.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == _player.name)
        {
            transform.LookAt(_player.GetComponent<Transform>());
            Vector3 speed = _direction * _speed * Time.deltaTime;
            transform.Translate(speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == _player.name)
        {
            _redLight.SetActive(false);
            _greenLight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == _player.name)
        {
            _redLight.SetActive(true);
            _greenLight.SetActive(false);
        }
    }
}
