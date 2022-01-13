using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private string _selectTag;
    [SerializeField] private Transform _pos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_selectTag))
        {
            other.transform.position = _pos.position;
        }
    }

}
