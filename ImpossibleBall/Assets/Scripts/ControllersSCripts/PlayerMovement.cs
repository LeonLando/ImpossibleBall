using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImpossibleBall.Inputs
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float Speed;
        private Rigidbody PlayerRigidbody;
        
        private void Awake()
        {
            PlayerRigidbody = GetComponent<Rigidbody>();
        }
        public void MoveCharacter(Vector3 Movement)
        {
            PlayerRigidbody.AddForce(Movement * Speed);
        }

    }

}
