using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBeUp : MonoBehaviour
{
    public int CanUp;
    public Vector3 Direction;
    public float Speed;
    private void FixedUpdate()
    {
        if (CanUp == 1)
        {
            transform.Translate(Direction.normalized * Speed);
        }
        if (CanUp == 2)
        {
            transform.Translate(Direction.normalized * -Speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            CanUp = 0;
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
