using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShip : MonoBehaviour
{
    public int maxHP = 100;
    public static int hp = 100;
    public int damage = 20;

    public Sprite damaged1;
    public Sprite damaged2;

    private Animator anim;
    public EnemyShip enemy;

    public HealthBar healthBar;

    private SpriteRenderer spriteRenderer;

    public static bool canAttack = true;
    void Start()
    {
        anim = GetComponent<Animator>();
        hp = maxHP;
        healthBar.SetMaxHealth(hp);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
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
        healthBar.SetHealth(hp);
        if (hp <= 50) spriteRenderer.sprite = damaged1;
        if (hp <= 0) spriteRenderer.sprite = damaged2;
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
