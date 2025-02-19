using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalInfo : MonoBehaviour
{
    public GameObject animal;
    public AnimalData info;
    void Start()
    {
        info.gameObjectInScene = animal;
    }

    void Update()
    {
        
    }
}
