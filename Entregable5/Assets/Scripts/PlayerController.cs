using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 20f;
    private float zMax = 450f;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        //posicion inicial
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //linea de codigo para avanzar
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        //lineas de rotacion
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);
        
        //si supera los 450 bloques de avanzado
        if (transform.position.z >= zMax)
        {
            Debug.Log(message: "THE END");
            Time.timeScale = 0;
        }
    }
}
