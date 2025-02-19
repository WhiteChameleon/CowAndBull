using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionCow : MonoBehaviour
{
    public GameObject cow;
    private int evolution;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == cow.tag)
        {
            switch (coll.gameObject.tag)
            {
                case "cowLVL1":
                    Destroy(cow);
                    Destroy(coll.gameObject);
                    evolution = 1;
                    break;
                case "cowLVL2":
                    Destroy(cow);
                    Destroy(coll.gameObject);
                    evolution = 2;
                    break;
                case "cowLVL3":
                    Destroy(cow);
                    Destroy(coll.gameObject);
                    evolution = 3;
                    break;
            }
        }
    }
    void Update()
    {
        if(evolution > 0)
        {
            Evolution(evolution);
        }
    }
    void Evolution(int count)
    {

    }
}
