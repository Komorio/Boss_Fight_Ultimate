﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class BigBullet : Enemy
{
    private Rigidbody2D rigidBody;
    private Vector2 direction;

    [SerializeField]
    private BigBulletExplosion explosion;
    
    private void Awake(){
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        Coefficient = 0;
    }

    public void SetDirection(Vector2 cautionPosition){
        direction = (cautionPosition - (Vector2)gameObject.transform.position).normalized;
    }

    public void Execute(){
        gameObject.SetActive(true);
        rigidBody.velocity = direction * 15;
    }
    
    private void Reset(){
        gameObject.transform.localPosition = Vector2.zero;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D ohter){
        if(ohter.CompareTag("Boss") || ohter.CompareTag("Enemy")){
            return;
        }

        explosion.gameObject.transform.position = gameObject.transform.position;
        explosion.Execute();
        Reset();
    }

    // TODO : Character speed down

}
