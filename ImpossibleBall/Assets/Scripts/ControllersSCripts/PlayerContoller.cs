using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

namespace ImpossibleBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]


    public class PlayerContoller : MonoBehaviour
    {
        [SerializeField] private GameObject _playerObj;
        [SerializeField] private Rigidbody _playerRig;
        //[SerializeField] private Vector3 _chekPointTransform;
        private Vector3 _movement;
        private PlayerMovement _playerMovement;
        private PlayerHealth _playerhp;
        private PlayerChekPoint _playerChekPoint;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
            _playerhp = GetComponent<PlayerHealth>();
            _playerChekPoint = GetComponent<PlayerChekPoint>();
            _playerChekPoint.GetChekPointPosition(_playerObj.transform);
        }
        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.Horizontal_Axis);
            float vertical = Input.GetAxis(GlobalStringVars.Vertical_Axis);
            _movement = new Vector3(horizontal, 0, vertical).normalized;
        }

        private void FixedUpdate()
        {
            _playerMovement.MoveCharacter(_movement);
        }

        
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("ChekPoint"))
            {
                _playerChekPoint.GetChekPointPosition(other.transform); 
                Animator Anim = other.GetComponent<Animator>();
                Anim.SetBool("IsActive", true);
            }
        }

        public void TakeDamage()
        {
            _playerRig.isKinematic = true;
            _playerhp.TakeDamage();
            _playerRig.isKinematic = false;
        }

        public void GoToChekPoint()
        {
            _playerChekPoint.GoToChekPoint(_playerObj.transform);
        }

        public void ResetLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
