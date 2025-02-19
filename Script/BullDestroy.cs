using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullDestroy : MonoBehaviour
{
    public GameObject bull;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == bull.tag)
        {
            switch (coll.gameObject.tag)
            {
                case "bullLVL1":
                    Evolution(1);
                    break;
                case "bullLVL2":
                    Evolution(2);
                    break;
                case "bullLVL3":
                    Evolution(3);
                    break;
            }
            Destroy(bull);
            Destroy(coll.gameObject);
        }
    }
    public void Evolution(int num)
    {
        AppearAnimal.evolutionBullLVL[num - 1] = true;
        AppearAnimal.evolutionS = true;
        AppearAnimal.evolutionPosition.x = bull.transform.position.x;
        AppearAnimal.evolutionPosition.y = bull.transform.position.y;
        AppearAnimal.bullsCount[num-1] -= 2;
        AppearAnimal.bullsCount[num] += 1;
    }
}
