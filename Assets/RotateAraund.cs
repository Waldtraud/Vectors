using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAraund : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _speedOfRotation;

    void Update()
    {
        transform.RotateAround(_target.transform.position, Vector3.up, _speedOfRotation * Time.deltaTime);
    }
}
