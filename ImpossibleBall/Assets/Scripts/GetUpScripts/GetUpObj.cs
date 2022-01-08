using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUpObj : MonoBehaviour
{
    //[SerializeField] private bool Go = false;
    [SerializeField] private CanBeUp Obj;
    //public Vector3 Direction;
    //public float Speed;
    [SerializeField] private string SelectTag;
    //private ConstantForce ConForce;
    private Rigidbody Rig;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(SelectTag))
        {
            Rig = other.GetComponent<Rigidbody>();
            Rig.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            Obj = other.GetComponent<CanBeUp>();
            if (Obj.CanUp == 1)
            {
                Obj.CanUp = 2;
            }
            else
            {
                Obj.CanUp = 1;
            }
            
            //ConstantForce UpForce = other.gameObject.AddComponent(typeof(ConstantForce)) as ConstantForce;
            //ConForce = other.GetComponent<ConstantForce>();
            //ConForce.force = new Vector3(0, 11, 0);
        }
    }

    //private void FixedUpdate()
    //{
    //    if (Go)
    //    {
    //        Obj.transform.Translate(Direction.normalized * Speed);
    //    }
    //    if (!Go)
    //    {
    //        Obj.transform.Translate(Direction.normalized * -Speed);
    //    }
    //}
}
