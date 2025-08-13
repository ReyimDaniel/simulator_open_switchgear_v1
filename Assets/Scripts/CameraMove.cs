using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Перемещение
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    // Высота
    public KeyCode move1 = KeyCode.Q;
    public KeyCode move2 = KeyCode.E;
    // Поворот
    public KeyCode move3 = KeyCode.UpArrow; 
    public KeyCode move4 = KeyCode.DownArrow;
    public KeyCode move5 = KeyCode.RightArrow;
    public KeyCode move6 = KeyCode.LeftArrow;

    void Update()
    {
        //Перемещение
        if (Input.GetKey(moveLeft))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(moveRight))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(moveUp))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(moveDown))
        {
            transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
        }
        // Высота
        if (Input.GetKey(move1))
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(move2))
        {
            transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        }
        //Поворот
        if (Input.GetKey(move3))
        {
            transform.Rotate(5 * -moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(move4)) 
        {
            transform.Rotate(5 * moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(move5))
        {
            transform.Rotate(0, 5 * moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(move6))
        {
            transform.Rotate(0, 5 * -moveSpeed * Time.deltaTime, 0);
        }
    }
}