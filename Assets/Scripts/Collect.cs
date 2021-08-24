using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    void Start()
    {
        
    }


    void OnTriggerStay()
    {
        gameObject.SetActive(false);
    }
}
