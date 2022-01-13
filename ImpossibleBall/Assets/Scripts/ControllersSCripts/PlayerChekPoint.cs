using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChekPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _chekPointTransform;

    public void GetChekPointPosition(Transform pos)
    {
        _chekPointTransform = pos.position;
    }

    public void GoToChekPoint(Transform obj)
    {
        obj.position = _chekPointTransform;
    }


}
