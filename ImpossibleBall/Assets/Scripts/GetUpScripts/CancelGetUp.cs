using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelGetUp : MonoBehaviour
{
    private GameObject Obj;
    private ConstantForce ConForce;
    private Rigidbody Rig;
    private void OnTriggerEnter(Collider other)
    {
        //other.transform.Translate(Direction.normalized * Speed);

        ConForce = other.GetComponent<ConstantForce>();
        Rig = other.GetComponent<Rigidbody>();
        Rig.constraints = RigidbodyConstraints.None;
        Destroy(ConForce);
    }

    private void FixedUpdate()
    {
        
    }
}
