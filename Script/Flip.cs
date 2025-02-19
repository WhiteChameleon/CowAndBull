using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    float oldPosition;
    public GameObject creature;
    private bool faceRight = true;
    void Start()
    {
        oldPosition = creature.transform.position.x;
    }
    void Update()
    {
        if (oldPosition > creature.transform.position.x && !faceRight)
        {
            Do();
        }
        if (oldPosition < creature.transform.position.x && faceRight)
        {
            Do();
        }
        oldPosition = creature.transform.position.x;
    }
    private void Do()
    {
        Vector3 currentScale = creature.transform.localScale;
        currentScale.x *= -1;
        creature.transform.localScale = currentScale;
        faceRight = !faceRight;
    }
}
