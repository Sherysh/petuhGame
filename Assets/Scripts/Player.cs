using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int _timer;
    private bool isGrounded;
    private GameObject _menu;
    private GameObject _gui;
    [SerializeField] private float _speed; // Скорость движения, а в дальнейшем ускорение
    [SerializeField] private Vector3 _direction; // Направление движения
    [SerializeField] private Vector2 _rotation;
    [SerializeField] private Animator _animator;

    private void Awake()
    {
        _gui = GameObject.Find("GUIPanel");
        _menu = GameObject.Find("MenuPanel");
    }
    void Start()
    {
        _menu.SetActive(false);
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
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            _menu.SetActive(true);
            _gui.SetActive(false);
        }

    }

    private void FixedUpdate()
    {
        Move();
        Rotation();
        Eating();
    }

    private void Eating()
    {
        //Debug.Log(_timer);
        //Debug.Log(_animator.GetBool("Eat"));
        if (_timer == 0)
        {
            _animator.SetBool("Eat", false);
        }
        else if (_timer > 0)
        {
            _animator.SetBool("Eat", true);
            _timer = _timer - 1;
        }
        else
            _timer = 0;
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
