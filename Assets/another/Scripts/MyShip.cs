using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShip : MonoBehaviour
{
    public int maxHP = 100;
    public static int hp = 100;
    public int damage = 10;

    private Animator anim;
    public EnemyShip enemy;

    public static bool canAttack = true;
    void Start()
    {
        anim = GetComponent<Animator>();
        hp = maxHP;
    }

    void Update()
    {
        if (canAttack && Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("My " + hp);
            anim.SetTrigger("Play");
            Attack(enemy);
            canAttack = false;
        }
    }

    public void SetHealth(int healthp)
    {
        hp = healthp;
    }

    void Attack(EnemyShip enemy)
    {
        enemy.SetHealth(enemy.getHealth() - damage); 
    }

    public int getHealth()
    {
        return hp;
    }
}
