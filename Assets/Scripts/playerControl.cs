using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{   //aqui está definida a velocidade
    private float speed = 23.0f;
    private float turnSpeed = 75.0f;
    //aqui está definido os inputs
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //utiliza as preferencias em Edit > Project Settings
        //inputs do jogador
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //moving vehicle                        Time altera o movimento que é por frame para por segundos
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); move em linha reta
        //turning vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
     
    }
}
