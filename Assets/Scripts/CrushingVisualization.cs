using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrushingVisualization : MonoBehaviour
{
    public Sprite ver70;
    public Sprite ver30;
    public Sprite ver0;
    private SpriteRenderer spriteRender;

    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        while(Stats.hp >= 0) 
        {
            if (Stats.hp <= 70)
            { 
                spriteRender.sprite = ver70;
            }
            else if (Stats.hp <= 30)
            {
                spriteRender.sprite = ver30;
            }
            else if (Stats.hp <= 0)
            {
                spriteRender.sprite = ver0;
            }
        }
        
    }
}
