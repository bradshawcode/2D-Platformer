using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform background;
    [SerializeField] float cameraDistance = 30.0f;

    private void Awake()// before the game starts
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        background.position = new Vector3(player.position.x, background.position.y, background.position.z);
    }
}
