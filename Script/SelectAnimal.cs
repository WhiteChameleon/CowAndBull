using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnimal : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Behaviour scriptMove;
    public GameObject trigger;

    public float speedMove;
    private Vector2 vectorMove;
    public GameObject animal;
    public GameObject selectSprite;
    private bool select = false;
    private void Awake()
    {
        selectSprite.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        trigger.GetComponent<Collider2D>().enabled = false;
    }
    private void OnMouseDown()
    {
        scriptMove.enabled = select;
        select = !select;
        selectSprite.SetActive(select);
        trigger.GetComponent<Collider2D>().enabled = select;
    }
    private void Update()
    {
        if (select == true)
        {
            vectorMove.x = Input.GetAxis("Horizontal");
            vectorMove.y = Input.GetAxis("Vertical");
            rb.MovePosition(rb.position + vectorMove * speedMove * Time.deltaTime);
        }
    }
}
