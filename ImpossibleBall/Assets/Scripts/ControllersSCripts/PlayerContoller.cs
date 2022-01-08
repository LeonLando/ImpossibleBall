using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace ImpossibleBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    

    public class PlayerContoller : MonoBehaviour
    {
        public float JumpPower;
        [SerializeField] private bool IsGrounded;
        private Vector3 Movement;
        private PlayerMovement PlayerMovement;
        

        private void Awake()
        {
            PlayerMovement = GetComponent<PlayerMovement>();
            JumpPower = 200;
            IsGrounded = true;
        }
        void Update()
        {
            float Horizontal = Input.GetAxis(GlobalStringVars.Horizontal_Axis);
            float Vertical = Input.GetAxis(GlobalStringVars.Vertical_Axis);
            Movement = new Vector3(Horizontal, 0, Vertical).normalized;
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)  //
            {
                IsGrounded = false;
                GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
            }
        }

        private void FixedUpdate()
        {
            PlayerMovement.MoveCharacter(Movement);
        }

        

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ground"))
            {
                IsGrounded = true;
            }
        }

    }

}
