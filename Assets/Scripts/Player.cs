using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool isGrounded;
    [SerializeField] private float _speed; // �������� ��������, � � ���������� ���������
    [SerializeField] private Vector3 _direction; // ����������� ��������
    [SerializeField] private Vector2 _rotation;
    [SerializeField] private Animator _animator;

    void Start()
    {

    }

    void Update()
    {
        _direction.z = Input.GetAxis("Vertical");
        _direction.x = Input.GetAxis("Horizontal");
        _rotation.x += Input.GetAxis("Mouse X");
        if (Input.GetButtonDown("Jump") == true && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 300, 0));
        }
        if (_direction == Vector3.zero)
        {
            _animator.SetBool("Run", false);
            _animator.SetBool("Walk", false);
            _speed = 4f;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            _animator.SetBool("Run", true);
            _animator.SetBool("Walk", false);
            _speed = 8f;
        }
        else
        {
            _animator.SetBool("Run", false);
            _animator.SetBool("Walk", true);
            _speed = 4f;
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

    private void OnCollisionEnter()
    {
        isGrounded = true; 
    }
}
