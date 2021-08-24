using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] GameObject _FemaleWithKnife;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_FemaleWithKnife, transform);
    }

}
