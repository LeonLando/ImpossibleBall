using ImpossibleBall.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieObj : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerContoller>(out var _playerContr))
        {
            _playerContr = other.GetComponent<PlayerContoller>();
            _playerContr.TakeDamage();
        }
    }
}
