using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : Platform
{
    [SerializeField] private Ball ball;
    [SerializeField] private Transform spawnPoint;

    private void Awake()
    {
        Instantiate(ball, spawnPoint.position, Quaternion.identity);
    }
}
