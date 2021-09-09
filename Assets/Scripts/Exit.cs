using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private GameObject _minipetuh;
    void Awake()
    {
        _minipetuh = GameObject.Find("Toon Chick"); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == _minipetuh.name)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(0);
        }
    }
}
