using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBeh : MonoBehaviour
{
    public static bool pressed;
    public bool pe;

    void Start()
    {
        pressed = false;
    }
    void onButton()
    {
        pressed = true;
    }
}
