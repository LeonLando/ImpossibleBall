using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public string SelectTag;
    public Transform Pos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(SelectTag))
        {
            other.transform.position = Pos.position;
        }
    }

}
