using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hitCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        hitCount++;
        Debug.Log("You hit an object " + hitCount + " time(s).");
    }
}
