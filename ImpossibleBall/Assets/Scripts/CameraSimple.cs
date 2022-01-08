using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSimple : MonoBehaviour
{
    [SerializeField] private Transform PlayerTransform;
    private Vector3 Offset;
    
    void Start()
    {
        Offset = transform.position - PlayerTransform.position;
    }

    void Update()
    {
        transform.position = PlayerTransform.position + Offset;
    }
}
