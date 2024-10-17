using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public int maxHP = 100;
    public static int hp = 100;
    public int damage = 10;

    public Sprite damaged1;
    public Sprite damaged2;

    //private Animator anim;
    public MyShip me;

    public HealthBar healthBarEnemy;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        //anim = GetComponent<Animator>();
        hp = maxHP;
        healthBarEnemy.SetMaxHealth(hp);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (MyShip.canAttack == false && hp > 0) 
        {
            Debug.Log("Enemy " + hp);
            //anim.SetTrigger("ShootOn");
            Attack(me);
            MyShip.canAttack = true;
            
        }

    }

    void Attack(MyShip me)
    {
        me.SetHealth(me.getHealth() - damage);
    }

    public void SetHealth(int health)
    {
        hp = health;
        healthBarEnemy.SetHealth(hp);
        if (hp <= 50) spriteRenderer.sprite = damaged1;
        if (hp <= 0) spriteRenderer.sprite = damaged2;
    }

    public int getHealth()
    {
        return hp;
    }
}
