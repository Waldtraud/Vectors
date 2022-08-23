using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitRotation : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _angle;
    [SerializeField] private float _radius;
    [SerializeField] private float _degreesPerSecond;
    void Update()
    {
        _angle+=_degreesPerSecond*Time.deltaTime;
        if (_angle > 360)
            _angle -= 360;
        Vector3 orbit = Vector3.forward * _radius;
        orbit = Quaternion.Euler(0, _angle, 0) * orbit;

        transform.position = _gameObject.transform.position + orbit;
    }
}
