using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Declaring Variables
    //These variables change the player object's position
    //[SerializeField] float xValue = 0f;
    //[SerializeField] float yValue = 0f;
    //[SerializeField] float zValue = 0f;

    [SerializeField] float moveSpeed = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Moves the player object over 1 unit in the x-axis upon startup
        //transform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //Local stored variables for getting the horizontal and vertical axis
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

        //Moves the player object over 0.01 units in the x-axis every frame
        transform.Translate(xValue,0,zValue);
    }
}
