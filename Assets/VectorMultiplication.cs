using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMultiplication : MonoBehaviour
{    
    [SerializeField] private Transform _object;
    [SerializeField] private float _factor;

    private void Update()
    {
        transform.position = _object.position * _factor;
    }
}
