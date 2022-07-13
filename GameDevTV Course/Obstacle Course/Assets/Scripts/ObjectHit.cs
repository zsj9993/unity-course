using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material ObjectHitMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Player hit a wall");

        //Detects if the object is being collided by the player
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material = ObjectHitMaterial;
            gameObject.tag = "HitObject";
        }
    }
}
