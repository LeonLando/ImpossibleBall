using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroysPlatform : MonoBehaviour
{
    [SerializeField] private GameObject Obj;
    [SerializeField] private float Time;
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Timer());
    }


    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(Time);
        Destroy(Obj);
    }
}
