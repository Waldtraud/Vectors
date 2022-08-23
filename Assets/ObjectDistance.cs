using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDistance : MonoBehaviour
{
    [SerializeField] private Transform _objectFirst;
    [SerializeField] private Transform _objectSecond;
    private float _distance;

    private void Update()
    {
        _distance = (_objectFirst.position - _objectSecond.position).magnitude;        

        if (_distance < 1)
        {
            Debug.Log($"Dostance is <1 {_distance}. It is too closely");
        }
        if (_distance > 1)
        {
            Debug.Log($"Dostance is >1 {_distance}. It is OK");
        }
    }
}
