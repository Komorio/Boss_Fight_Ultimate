﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Blink : Character
{
    private float char_Speed;
    private int char_Hp;
    private int char_Energy;
    private int char_AbilityPrice;
    private int char_JumpForce;

    [SerializeField]
    private Blink abilitySkill;


    private void Start()
    {
        abilitySkill.Init();
        char_Hp = 700;
        char_Speed = 7.7f;
        char_Energy = 100;
        char_AbilityPrice = 33;
        char_JumpForce = 5;

        IDInit(5,5,5);
        RankInit(0,2,4);
        StatInit(char_Speed, char_Hp, char_Energy, char_AbilityPrice, char_JumpForce, abilitySkill);
    }

    private void FixedUpdate()
    {
        Move();
    }
}
