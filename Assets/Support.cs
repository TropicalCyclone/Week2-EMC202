using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support : Player
{
    protected float _healAmount;
    public Support()
    {
        _healAmount = 20;
        _name = "";
        _vitality = 0.7f;
        _strength = 1.0f;
        _speed = 1.0f;
        _defence = 1.0f;
        _attack = 1.0f;
        _attackRate = 1.0f;
        _ammoCapacity = 10;
    }

    public Support(string Name, float VIT, float STR, float SP, float DEF, int ammoCap)
    {
        Name = _name;
        _vitality = VIT;
        _strength = STR;
        _speed = SP;
        _defence = DEF;
        _attack = SP;
        _ammoCapacity = ammoCap;
    }
    
    public void HealPlayer(float targetPlayerHealth,float targetMaxPlayerHealth)
    {
        while (targetPlayerHealth < targetMaxPlayerHealth)
        {
            targetPlayerHealth = +_healAmount;
        }
    }
}
