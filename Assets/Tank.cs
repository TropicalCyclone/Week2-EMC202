using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Player
{
    protected float _sheildHealth;
    public Tank()
    {
        _name = "";
        _sheildHealth = 100;
        _vitality = 1.35f;
        _strength = 1.0f;
        _speed = 0.90f;
        _defence = 5.0f;
        _attack = 0.5f;
        _damageReduction = 0.3f;
        _attackRate = 0.8f;
        _ammoCapacity = 3;
    }
    public Tank(string Name, float VIT, float STR, float SP, float ATT, float DEF, float DammRed, float AttRate, int ammoCap)
    {
        _name = Name;
        _vitality = VIT;
        _strength = STR;
        _speed = SP;
        _defence = DEF;
        _attack = ATT;
        _damageReduction = DammRed;
        _attackRate = AttRate;
    }


}
