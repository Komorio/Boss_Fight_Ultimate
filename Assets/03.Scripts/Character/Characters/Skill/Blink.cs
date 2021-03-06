﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour, ISkill
{

    private Character targetCharacter;
    private int blinkDistance;
    public void Init()
    {
        blinkDistance = 2;
        targetCharacter = gameObject.GetComponent<Character>();
    }

    public bool Repeat()
    {
        return false;
    }

    public void Enter()
    {

        StartCoroutine(targetCharacter.ShowEffect(targetCharacter.skilEffect[0],false));


        if (targetCharacter.GetComponent<SpriteRenderer>().flipX)
        {
            if (targetCharacter.transform.position.x - blinkDistance > -8.3f)
                targetCharacter.transform.Translate(new Vector2(-blinkDistance, 0));
            else if (targetCharacter.transform.position.x - blinkDistance < -8.3f)
                targetCharacter.transform.position = new Vector2 (-8.3f, targetCharacter.transform.position.y);

        }
        else if (targetCharacter.GetComponent<SpriteRenderer>().flipX == false)
        {

            if (targetCharacter.transform.position.x + blinkDistance < 8.3f)
                targetCharacter.transform.Translate(new Vector2(blinkDistance, 0));
            else if (targetCharacter.transform.position.x + blinkDistance > 8.3f)
                targetCharacter.transform.position = new Vector2(8.3f, targetCharacter.transform.position.y);
        }

    }


    public void Excute() {
  
    }

    public void Exit() { 
    
    }


}
