using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material ObjectHitMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Player hit a wall");
        GetComponent<MeshRenderer>().material = ObjectHitMaterial;
    }
}
