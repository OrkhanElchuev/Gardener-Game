using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    // For readability in engine
    [Header("Enemy Configs")]
    [Range(0f, 10f)] [SerializeField] float movingSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }
    
    // Move enemy (independent from the FPS of device)
    private void MoveEnemy()
    {
        transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
    }
}
