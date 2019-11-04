﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class enemySpawn : UnityEvent<Transform> { }
public class Enemy : MonoBehaviour
{
    public enemySpawn onSpawn;
    private void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        onSpawn.Invoke(player.transform);
    }
}