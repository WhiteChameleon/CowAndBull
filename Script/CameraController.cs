using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public float VelocityMove; // Скорость движения - указать в инспекторе
    public Transform Left;
    public Transform Right;
    public Transform Bottom;
    public Transform Top;

    void Update()
    {
        /*if (Input.mousePosition.x < Left.position.x)
        print(Input.mousePosition.x);
        print(Right.position.x);
        {
            transform.position += new Vector3(-VelocityMove, 0, 0);
        }
        if (Input.mousePosition.x > Right.rectTransform.position.x)
        {
            transform.position += new Vector3(VelocityMove, 0, 0);
        }
        if (Input.mousePosition.y < Bottom.position.y)
        {
            transform.position += new Vector3(0, -VelocityMove, 0);
        }
        if (Input.mousePosition.y > Top.position.y)
        {
            transform.position += new Vector3(0, VelocityMove, 0);
        }*/
    }
}
