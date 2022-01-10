using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : IntractableBody
{
    private void Awake()
    {
        this.gameObject.transform.parent = GameManager.Instance.Map;
    }
}
