using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Quaternion _nullRotation;
    private GameObject _petuh;

    void Start()
    {
        _petuh = GameObject.Find("Petuh");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == _petuh.name)
        {
            transform.LookAt(_petuh.GetComponent<Transform>());
        }
    }
}
