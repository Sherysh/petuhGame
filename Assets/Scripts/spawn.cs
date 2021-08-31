using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] GameObject _FemaleWithKnife;
    //[SerializeField] GameObject _targetPos;

    void Start()
    {
        GameObject enemy = Instantiate(_FemaleWithKnife, transform);

    }

}
