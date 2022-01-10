using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

namespace ImpossibleBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]


    public class PlayerContoller : MonoBehaviour
    {
        public float JumpPower;
        [SerializeField] private bool IsGrounded;
        private Vector3 Movement;
        private PlayerMovement PlayerMovement;
        [SerializeField] private GameObject PlayerObj;
        [SerializeField] private Vector3 ChekPointTransform;
        private float Health = 3;
        [SerializeField] private Text HealthText;


        private void Awake()
        {
            ChekPointTransform = PlayerObj.transform.position;
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
            if (other.CompareTag("ChekPoint"))
            {
                ChekPointTransform = other.transform.position;
                Animator Anim = other.GetComponent<Animator>();
                Anim.SetBool("IsActive", true);
            }
        }

        public void TakeDamage()
        {

            if (Health > 0)
            {
                Health -= 1;
                PlayerObj.transform.position = ChekPointTransform;

            }
            if (Health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            HealthText.text = Health.ToString();
        }
    }

}
