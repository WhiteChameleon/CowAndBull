using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject main_Camera;
    public float xMove;
    public float yMove;
    public float xPos;
    public float yPos;
    private bool move = true;
    void Update()
    {
        transform.position = new Vector3(main_Camera.transform.position.x + xPos, main_Camera.transform.position.y + yPos, 0);
        if (transform.position.x > 16.9f || transform.position.x < -16.9f || transform.position.y > 9f || transform.position.y < -9f)
        {
            move = false;
        }
        else
        {
            move = true;
        }
    }
    void OnMouseOver()
    {
        if (move == true)
        {
            main_Camera.transform.position += new Vector3(xMove, yMove, 0);
        }
    }
}
