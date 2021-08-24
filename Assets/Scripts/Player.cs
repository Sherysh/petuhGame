using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed; // Скорость движения, а в дальнейшем ускорение
    [SerializeField] private Vector3 _direction; // Направление движения
    [SerializeField] private Vector2 _rotation;

    void Start()
    {

    }

    void Update()
    {
        _direction.z = Input.GetAxis("Vertical");
        _direction.x = Input.GetAxis("Horizontal");
        _rotation.x += Input.GetAxis("Mouse X");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 300, 0));
        }
    }

    private void FixedUpdate()
    {
        Move();
        Rotation();
    }

    private void Move()
    {
        Vector3 speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
    }

    private void Rotation()
    {
        transform.localRotation = Quaternion.Euler(0, _rotation.x, 0);
    }

    public bool isGrounded;
    private void OnCollisionEnter()
    {
        isGrounded = true; 
    }
}
