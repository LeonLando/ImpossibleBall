using ImpossibleBall.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieObj : MonoBehaviour
{
    private PlayerContoller PlayerContr;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerContr = other.GetComponent<PlayerContoller>();
            PlayerContr.TakeDamage();
        }
        //else
        //{
        //    Destroy(other.gameObject);
        //}
    }
}
