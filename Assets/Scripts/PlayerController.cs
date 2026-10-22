using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; //Decide la velocidad en la que se moveran los palos
    public float topHeight; //Decide el tope de arriba de los palos
    public float botHeight; //Decide el tope de abajo de los palos
    public bool useArrowKeys = false; //Para decidir que palo se maneja con las teclas de flechas

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle();
    }

    void MovePaddle()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, LimitsPaddle(), this.gameObject.transform.position.z);
    }
    float LimitsPaddle()
    {
        float newY = this.gameObject.transform.position.y + (PaddleDirection() * moveSpeed * Time.deltaTime);
        if (newY > topHeight)
        {
            newY = topHeight;
        }
        if (newY < botHeight)
        {
            newY = botHeight;
        }
        return newY;
    }
    float PaddleDirection()
    {
        float direccion = 0f;

        if (useArrowKeys == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                direccion = -1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                direccion = -1f;
            }
        }
        return direccion;
    }
}
