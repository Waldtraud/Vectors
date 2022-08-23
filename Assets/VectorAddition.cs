using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorAddition: MonoBehaviour
{
    [SerializeField] private Transform _objectFirst;
    [SerializeField] private Transform _objectSecond;     

    private void Update()
    {
       transform.position = _objectFirst.position + _objectSecond.position;
    }    
}
