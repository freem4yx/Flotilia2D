using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public int maxHP = 100;
    public static int hp = 100;
    public int damage = 10;

    private Animator anim;
    public MyShip me;

    void Start()
    {
        anim = GetComponent<Animator>();
        hp = maxHP;
    }

    void Update()
    {
        if (MyShip.canAttack == false) 
        {
            Debug.Log("Enemy " + hp);
            anim.SetTrigger("ShootOn");
            Attack(me);
            MyShip.canAttack = true;
            
        }

    }

    void Attack(MyShip me)
    {
        me.SetHealth(me.getHealth() - damage);
    }

    public void SetHealth(int healthp)
    {
        hp = healthp;
    }

    public int getHealth()
    {
        return hp;
    }
}
