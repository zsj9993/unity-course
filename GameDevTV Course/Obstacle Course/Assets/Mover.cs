using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Declaring Variables
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Moves the player object over 1 unit in the x-axis upon startup
        //transform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the player object over 0.01 units in the x-axis every frame
        transform.Translate(xValue,yValue,zValue);
    }
}
