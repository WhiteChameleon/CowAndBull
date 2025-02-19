using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BullsAndCows : MonoBehaviour
{
    public static List<string> answerNumber = new List<string>();
    public static List<string> randomNumber = new List<string>();
    public string answerNumberStr;
    public string randNumberStr;
    public int[] randomNumberInt = new int[4];

    public TMP_Text answer;
    public TMP_Text history;
    public TMP_Text result;

    public int cow;
    public int bull;
    private void Start()
    {
        RandomNumber();
    }
    private void Update()
    {
        if (answerNumber.Count < 1)
        {
            return;
        }
        answerNumberStr = "";
        foreach (var num in answerNumber)
        {
            answerNumberStr += num;
        }
        answer.text = answerNumberStr;
        answerNumberStr = "";
        if (answerNumber.Count > 4)
        {
            answerNumber.RemoveAt(4);
            Result();
        }
    }
    private void RandomNumber()
    {
        bool contains;
        for (int i = 0; i < 4; i++)
        {
            do
            {
                contains = false;
                randomNumberInt[i] = Random.Range(0, 10);
                for (int k = 0; k < i; k++)
                    if (randomNumberInt[k] == randomNumberInt[i])
                        contains = true;
            } while (contains);
        }
        randNumberStr = randomNumberInt[0].ToString() + randomNumberInt[1] + randomNumberInt[2] + randomNumberInt[3];
    }
    private void Result()
    {
        foreach (var num in answerNumber)
        {
            answerNumberStr += num;
        }
        if (answerNumberStr == randNumberStr)
        {
            switch (randomNumberInt[0])
            {
                case >= 7:
                    AnimalManager.animalAdd = 5;
                    break;
                case 6:
                    AnimalManager.animalAdd = 4;
                    break;
                case 5:
                    AnimalManager.animalAdd = 3;
                    break;
                case <=4:
                    AnimalManager.animalAdd = 2;
                    break;
            }
            SceneManager.LoadScene("Game");
        }
        answer.text = "";
        for (int i = 0; i < 4; i++)
        {
            randomNumber.Add(randomNumberInt[i].ToString());
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (answerNumber[i] == randomNumber[j])
                {
                    if (i == j)
                        bull += 1;
                    else
                        cow += 1;
                }
            }
        }
        result.text = "Отгадано быков : " + bull + ", а коров : " + cow;
        history.text += answerNumberStr + " -- быков : " + bull + ", коров : " + cow + "\r\n";
        answerNumber.Clear();
        bull = 0;
        cow = 0;
    }
}
