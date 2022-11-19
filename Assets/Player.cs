using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private  int hitPoints;
    public int strength;
    public int speed;
    private int defence;
    private int fireRate;
    public int ammoCapacity;

    public void damagePlayer(int dam)
    {
        hitPoints -= dam;
    }

    public Player()
    {
        hitPoints = 100;
        strength = 1;  
        speed = 1;
        defence = 1;
        fireRate = 1;
        ammoCapacity = 10;
    }

    public Player(int HP,int STR,int SP, int DEF, int rate, int ammoCap)
    {
        HP = hitPoints;
        STR = strength;
        SP = speed;
        DEF = defence;
        rate = fireRate;
        ammoCap = ammoCapacity;
    }

    public int getHitpoints()
    {
        return hitPoints;
    }

    public int getFirerate()
    {
        return fireRate;
    }
    public void ammoReduce(int Rate)
    {
        while(ammoCapacity > 0)
        {
            ammoCapacity -= Rate;
        }
    }
}
