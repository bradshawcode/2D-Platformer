using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType
{
    PlayerBody,
    EnemyBody
}

public class Damage : MonoBehaviour
{
    [SerializeField] float damage;
    [SerializeField] DamageType damageType;
    [SerializeField] DamageType acceptType;

    public DamageType DamageType { get { return damageType; } }
    public DamageType AcceptType { get { return acceptType; } }
}
