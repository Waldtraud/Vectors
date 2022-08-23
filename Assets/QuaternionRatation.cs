using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionRatation : MonoBehaviour
{

    [SerializeField] private Vector3 _rotationVelocity;    

    void Update()
    {
        Quaternion quaternion = Quaternion.Euler(_rotationVelocity * Time.deltaTime);
        transform.rotation = transform.rotation * quaternion;
    }
}
