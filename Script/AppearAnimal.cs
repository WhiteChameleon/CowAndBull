using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearAnimal : MonoBehaviour
{
    public static int[] cowsCount = new int[4]; //колво коров
    public static int[] bullsCount = new int[3]; //колво быков
    public GameObject[] cows = new GameObject[4];
    public GameObject[] bulls = new GameObject[3];
    public static bool[] evolutionCowLVL = new bool[3];
    public static bool[] evolutionBullLVL = new bool[2];
    public static bool evolutionS;
    public static Vector3 evolutionPosition;
    private void Start()
    {
        evolutionS = false;
        for (int j = 0; j < 3; j++)
        {
            if (cowsCount[j] > 0 || bullsCount[j] > 0)
            {
                for (int i = cowsCount[j]; i > 0; i--)
                {
                    Instantiate(cows[j]);
                }
                for (int i = bullsCount[j]; i > 0; i--)
                {
                    Instantiate(bulls[j]);
                }
            }
        }
    }
    private void Update()
    {
        if (evolutionS == true)
        {
            Debug.Log(evolutionS);
            Evolution();
        }
    }
    private void Evolution()
    {
        for (int i = 0; i < 3; i++)
        {
            if (evolutionCowLVL[i] == true)
            {
                Instantiate(cows[i+1], new Vector3(evolutionPosition.x, evolutionPosition.y, 0), Quaternion.identity);
                evolutionCowLVL[i] = false;
                evolutionS = false;
            }
        }
        for (int i = 0; i < 2; i++)
        {
            if (evolutionBullLVL[i] == true)
            {
                Instantiate(bulls[i+1], new Vector3(evolutionPosition.x, evolutionPosition.y, 0), Quaternion.identity);
                evolutionBullLVL[i] = false;
                evolutionS = false;
            }
        }
    }
}
