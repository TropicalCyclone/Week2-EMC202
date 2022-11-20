using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    protected string _name;
    private float _baseHealth;
    protected float _strength;
    protected float _speed; 
    protected float _defence;
    protected float _attackRate;
    protected float _attack;
    protected float _vitality;
    protected int _ammoCapacity;
    protected float _damageReduction;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _name = "Steve";
            }
            else
            {
                _name = value;
            }
        }
    }

    public float maxHealth => _baseHealth * _vitality;


    public Player()
    {
        _name = "";
        _baseHealth = 100.0f;
        _strength = 1.0f;
        _speed = 1.0f;
        _defence = 1.0f;
        _attack = 1.0f;
        _attackRate = 1.0f;
        _ammoCapacity = 10;
    }

    public Player(string Name, float STR, float SP, float DEF, int ammoCap)
    {
        Name = _name;
        STR = _strength;
        SP = _speed;
        DEF = _defence;
        ammoCap = _ammoCapacity;
    }

    public float getHitpoints()
    {
        return maxHealth;
    }

    public float getFirerate()
    {
        return _attackRate;
    }
    public void ammoReduce(int Rate)
    {
        while (_ammoCapacity > 0)
        {
            _ammoCapacity -= Rate;
        }
    }

    public string GetProperties()
    {
        var properties = $"{nameof(maxHealth)}:{maxHealth},{nameof(_defence)}:{_defence},{nameof(_attackRate)}:{_attackRate},{nameof(_speed)}:{_speed},{nameof(_strength)}:{_strength},{nameof(_ammoCapacity)}:{_ammoCapacity},";
        return properties;
    }
}
