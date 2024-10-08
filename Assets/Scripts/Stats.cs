using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int maxHP = 100;
    public static int hp;
    public int damage;

    public HealthBar healthBar;

    void Start()
    {
        hp = maxHP;
        healthBar.SetMaxHealth(maxHP);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(damage);
        }
    }

    void TakeDamage(int damage)
    {
        hp -= damage;
        healthBar.SetHealth(hp);
    }

}

