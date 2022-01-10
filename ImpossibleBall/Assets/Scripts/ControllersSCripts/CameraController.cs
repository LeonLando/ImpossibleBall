using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [DisallowMultipleComponent]
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _transformOfPlayer;
        [SerializeField] private GameObject PlayerObj;
        [SerializeField] private float _turnSpeed = 4.0f;
        [SerializeField] private float _distance = -4f;
        [SerializeField] private float _height = 5f;
        private Vector3 _offset;

        private void Awake()
        {
            _transformOfPlayer = PlayerObj.transform;
        }

        private void Start()
        {
            _offset = new Vector3(0, _height, _distance);
        }


        private void Update()
        {
            _transformOfPlayer = PlayerObj.transform;
        }

        private void LateUpdate()
        {
            _offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * _turnSpeed, Vector3.up) * _offset;
            var position = _transformOfPlayer.position;
            transform.position = position + _offset;
            transform.LookAt(position);
        }
    }
















    //[SerializeField] private Transform PlayerTransform;
    //private  Rot;
    //private Vector3 Offset;
    ////private Quaternion OffsetRotation;

    //void Start()
    //{
    //    Offset = transform.position - PlayerTransform.position;
    //    Rot = transform.rotation;
    //    //OffsetRotation = transform.rotation - PlayerTransform.rotation;
    //}

    //void Update()
    //{



    //    transform.position = PlayerTransform.position + Offset;
    //    //transform.rotation = PlayerTransform.rotation;
    //}

