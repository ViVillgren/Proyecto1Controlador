using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Velocidad movimiento
    private float speed = 20;
    //Velocidad Giro
    private float turnSpeed = 50;
    private float horizontalInput;
    private float verticalInput;

   
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Movimiento hacia delante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Movimiento lateral
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        //Rotacion
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    
    }
}
