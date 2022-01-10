using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpForce;
    private bool isTouching;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePlayer();
        PlayerJump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }

        if (collision.collider.tag == "EndGame")
            UnityEngine.SceneManagement.SceneManager.LoadScene("FirstLevel"); // reload scene
    }

    private void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isTouching == true) // Checks to see if space is pressed.
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isTouching = false;
        }
    }

}
