using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    [SerializeField] private Vector2 _rotation;
    private GameObject _target;


    private void Awake()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Start()
    {
        _target = GameObject.Find("Toon Chicken");
    }

    void Update()
    {
        _rotation.y += Input.GetAxis("Mouse Y");
    }

    void FixedUpdate()
    {
        if (_rotation.y > -90 & _rotation.y < 90)
            transform.localRotation = Quaternion.Euler(-_rotation.y, 0, 0);
        else if (_rotation.y > -90)
            _rotation.y = 90;
        else if (_rotation.y < 90)
            _rotation.y = -90;

        //transform.LookAt(_target.GetComponent<Transform>());

    }
}
