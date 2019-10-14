using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float currentEnemySpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    // Move enemy (independent from the FPS of device)
    private void MoveEnemy()
    {
        transform.Translate(Vector2.left * currentEnemySpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentEnemySpeed = speed;
    }
}
