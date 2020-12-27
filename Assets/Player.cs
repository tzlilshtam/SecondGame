using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 105f;
    [SerializeField]
    float mapField = 13f;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapField, mapField);
        rb.MovePosition(newPosition);
    }

    void OnCollisionEnter2D()
    {
        score.scoreValue = 0;
        FindObjectOfType<GameManager>().EndGame();
    } 
}
