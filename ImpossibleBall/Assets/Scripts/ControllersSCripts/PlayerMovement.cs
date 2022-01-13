using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImpossibleBall.Inputs
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float _speed;
        [SerializeField] private float _jumpPower;
        [SerializeField] private bool _isGrounded;
        private Rigidbody _playerRigidbody;


        private void Awake()
        {
            _playerRigidbody = GetComponent<Rigidbody>();
            _jumpPower = 200;
            _isGrounded = true;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)  
            {
                _isGrounded = false;
               _playerRigidbody.AddForce(new Vector3(0, _jumpPower, 0));
            }

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ground"))
            {
                _isGrounded = true;
            }
        }


        public void MoveCharacter(Vector3 Movement)
        {
            _playerRigidbody.AddForce(Movement * _speed);
        }

    }

}
