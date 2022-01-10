using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : IntractableBody
{
    [SerializeField] private Transform position;
    [SerializeField] private Rigidbody2D player;

    public Rigidbody2D Movement { get { return player; } set { player = value; } }

    private void Update()
    {
        PlayerHealth();
        CheckPlayerPostion();
    }
    private void PlayerHealth()
    {
        if (Health == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("FirstLevel"); // reload scene
        }
    }
    private void CheckPlayerPostion()
    {
        if (position.position.x <= -9 && position.position.y <= -9 || position.position.y <= -9 || position.position.x <= -9)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("FirstLevel"); // reload scene
        }

    }
}
// to make the camera follow use the position + the size. as player is in the mid or 2 from the side move and move by how much the player moves