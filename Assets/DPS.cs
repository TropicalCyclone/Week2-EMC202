using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPS : Player
{   
    public DPS()
    {
        _name = "";
        _vitality = 0.85f;
        _strength = 2.0f;
        _speed = 1.5f;
        _defence = 0.8f;
        _attack = 0.5f;
        _attackRate = 1.5f;
        _ammoCapacity = 20;
    }
    public float DPSAttack => _strength * _attackRate + _attack;

    public DPS(string Name, float VIT, float ATT, float STR, float SP, float DEF, float AttRate, int AmmoCap)
    {
        Name = _name;
        _vitality = VIT;
        _strength = STR;
        _attack = ATT;
        _speed = SP;
        _defence = DEF;
        _attackRate = AttRate;
        _ammoCapacity = AmmoCap;
    }
}
