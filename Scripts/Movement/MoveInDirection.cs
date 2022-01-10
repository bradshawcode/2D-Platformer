using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInDirection : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    private void Update() { this.gameObject.transform.Translate(direction); }
}
