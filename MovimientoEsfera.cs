using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEsfera : MonoBehaviour
{

    public float rotacion = 100f; // Valor para la rotacion con Q y E
    public float velocidad = 10f; // Valor para el movimiento con WASD


    void Start()
    {

    }

   
    void Update()
    {
        Rotate(); //Hacemos el update del metodo Rotate()
        Move(); //Hacemos el update del metodo Move()
        Velocidad(); //Hacemos el update del metodo Velocidad()
    }

    void Rotate() //Metodo que controla la rotación de nuestra esfera cuando pulsamos Q o E.
    {
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(new Vector3(0f, -rotacion, 0f) * Time.deltaTime);//Si pulsamos la Q rotamos hacia la izquierda
        else if (Input.GetKey(KeyCode.E))
            transform.Rotate(new Vector3(0f, rotacion, 0f) * Time.deltaTime); //Si pulsamos la E rotamos hacia la derecha
    }

    void Move() //Metodo que controla el movimiento de nuestra esfera al pulsar WASD.
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime); //Nos movemos hacia delante
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);//Nos movemos hacia detras
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);//Nos movemos hacia la izquierda
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);//Nos movemos hacia la derecha

    }

    void Velocidad() //Metodo que controla la velocidad a la que se mueve nuestra esfera que se incrementa si pulsamos H y decrece si pulsamos L.
    {
        if (Input.GetKey(KeyCode.H)) //Incrementamos la velocidad.
            velocidad = velocidad + 1;
        if (Input.GetKey(KeyCode.L)) //Decrementamos la velocidad.
            velocidad = velocidad - 1;

    }

}
