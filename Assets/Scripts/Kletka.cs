using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kletka : MonoBehaviour
{
    //private GameObject _zone;
    private GameObject _sharik;
    private GameObject _reshetka;

    void Start()
    {
        //_zone = GameObject.Find("Zone");
        _sharik = GameObject.Find("Sharik");
        _reshetka = GameObject.Find("Reshetka");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == _sharik.name)
        {
            _reshetka.SetActive(false);
        }
    }
}
