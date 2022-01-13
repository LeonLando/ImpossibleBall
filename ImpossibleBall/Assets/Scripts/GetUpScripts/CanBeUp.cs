using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBeUp : MonoBehaviour
{
    public int _canUp;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;
    private void FixedUpdate()
    {
        if (_canUp == 1)
        {
            transform.Translate(_direction.normalized * _speed);
        }
        if (_canUp == 2)
        {
            transform.Translate(_direction.normalized * -_speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _canUp = 0;
        }
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Ground"))
    //    {
    //        CanUp = 0;
    //    }
    //}
}
