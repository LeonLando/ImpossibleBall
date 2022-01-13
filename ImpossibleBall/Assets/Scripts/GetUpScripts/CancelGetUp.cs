using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelGetUp : MonoBehaviour
{
    private GameObject _obj;
    private ConstantForce _conForce;
    private Rigidbody _rig;
    private void OnTriggerEnter(Collider other)
    {
        //other.transform.Translate(Direction.normalized * Speed);

        _conForce = other.GetComponent<ConstantForce>();
        _rig = other.GetComponent<Rigidbody>();
        _rig.constraints = RigidbodyConstraints.None;
        Destroy(_conForce);
    }

    private void FixedUpdate()
    {
        
    }
}
