using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketMoveCamera : MonoBehaviour
{
    public GameObject main_Camera;
    public float xMove;
    public float xPos;
    private bool move = true;
    void Update()
    {
        transform.position = new Vector3(main_Camera.transform.position.x + xPos, 0, 0);
        if (transform.position.x > 16.9f || transform.position.x < -16.9f)
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
            main_Camera.transform.position += new Vector3(xMove, 0, 0);
        }
    }
}
