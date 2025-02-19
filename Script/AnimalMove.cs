using System.Collections;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    public GameObject animal;
    private Vector2 moveVector;
    private int randomSecMove;

    private int[] array = new int[] { 1, -1};
    public int randomVectorX;
    public int randomVectorY;

    private bool move = false;
    private void Start()
    {
        StartCoroutine("Move", randomSecMove);
    }
    private void Update()
    {
        if (move == true)
        {
            animal.transform.position += new Vector3(moveVector.x * randomVectorX, moveVector.y * randomVectorY, 0);
        }
    }
    IEnumerator Move(int sec)
    {
        move = true;
        yield return new WaitForSeconds(sec);
        move = false;
        randomSecMove = Random.Range(0, 6);
        moveVector.x = Random.Range(0, 0.01f);
        moveVector.y = Random.Range(0, 0.01f);
        randomVectorX = array[Random.Range(0, 2)];
        randomVectorY = array[Random.Range(0, 2)];
        StartCoroutine("Move", randomSecMove);
    }
}
