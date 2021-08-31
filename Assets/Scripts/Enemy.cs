using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Quaternion _nullRotation;
    private GameObject petuh;

    void Start()
    {
        petuh = GameObject.Find("Petuh");
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == petuh.name)
        {
            transform.LookAt(petuh.GetComponent<Transform>());
        }
    }
}
