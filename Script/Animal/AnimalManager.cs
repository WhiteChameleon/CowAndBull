using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    public List<GameObject> listAnimal = new List<GameObject>();
    public static int animalAdd;
    public GameObject[] animal = new GameObject[2];
    void Start()
    {
        if (animalAdd > 0)
        {
            AnimalAdd(animalAdd);
        }
        for (int i = 0; i < listAnimal.Count; i++)
        {
            Instantiate(listAnimal[i]);
        }
    }
    void Update()
    {

    }
    public void AnimalAdd(int num)
    {
        animalAdd = 0;
        for (int i = num; i > 0; i-- )
        {
            listAnimal.Add(animal[0]);
        }
    }
}
[System.Serializable]
public struct AnimalData
{
    public string gender; // ���
    public string element; // ������
    public string mood; // ����������
    public GameObject gameObjectInScene; // ������ �� �����
    public int level; // �������
    public float strength; // ����
    public float health; // ��������
}
