using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    protected string _name;
    private float _health;
    protected float _strength;
    protected float _speed;
    protected float _defence;
    protected float _fireRate;
    protected int _ammoCapacity;

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

    public Player()
    {
        _name = "";
        _health = 100.0f;
        _strength = 1.0f;
        _speed = 1.0f;
        _defence = 1.0f;
        _fireRate = 1.0f;
        _ammoCapacity = 10;
    }

    public Player(float STR, float SP, float DEF, float rate, int ammoCap)
    {
        STR = _strength;
        SP = _speed;
        DEF = _defence;
        rate = _fireRate;
        ammoCap = _ammoCapacity;
    }

    public void damagePlayer(int dam)
    {
        _health -= dam;
    }

    public float getHitpoints()
    {
        return _health;
    }

    public float getFirerate()
    {
        return _fireRate;
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
        var properties = $"{nameof(_health)}:{_health},{nameof(_defence)}:{_defence},{nameof(_fireRate)}:{_fireRate},{nameof(_speed)}:{_speed},{nameof(_strength)}:{_strength},{nameof(_ammoCapacity)}:{_ammoCapacity},";
        return properties;
    }
}
