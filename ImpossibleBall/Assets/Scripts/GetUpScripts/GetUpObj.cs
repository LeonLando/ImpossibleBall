using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUpObj : MonoBehaviour
{
    [SerializeField] private CanBeUp _obj;
    [SerializeField] private string _selectTag;
    private Rigidbody _rig;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_selectTag))
        {
            _rig = other.GetComponent<Rigidbody>();
            _rig.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            _obj = other.GetComponent<CanBeUp>();
            if (_obj._canUp == 1)
            {
                _obj._canUp = 2;
            }
            else
            {
                _obj._canUp = 1;
            }
            
        }
    }

}
