using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kletka : MonoBehaviour
{
    private GameObject _sharik;
    private GameObject _goodLight;

    void Start()
    {
        _sharik = GameObject.Find("Sharik");
        _goodLight = GameObject.Find("SucsessLight");
        _goodLight.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == _sharik.name)
        {
            _goodLight.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
