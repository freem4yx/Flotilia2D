using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject thing;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject copiedThing = Instantiate(thing);
        }
    }
    
}
